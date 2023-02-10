﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MediaPlayer.Models
{
    internal class ImageTools
    {

        private readonly int[] _alpha;
        private readonly int[] _red;
        private readonly int[] _green;
        private readonly int[] _blue;

        private readonly int _width;
        private readonly int _height;

        private readonly ParallelOptions _pOptions = new ParallelOptions { MaxDegreeOfParallelism = 16 };

        public static Image GaussianBlur(Image image, int radial)
        {
            ImageTools gaussianBlur = new ImageTools(image as Bitmap);
            return gaussianBlur.Process(radial);
        }
        private ImageTools(Bitmap image)
        {
            var rct = new Rectangle(0, 0, image.Width, image.Height);
            var source = new int[rct.Width * rct.Height];
            var bits = image.LockBits(rct, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            Marshal.Copy(bits.Scan0, source, 0, source.Length);
            image.UnlockBits(bits);

            _width = image.Width;
            _height = image.Height;

            _alpha = new int[_width * _height];
            _red = new int[_width * _height];
            _green = new int[_width * _height];
            _blue = new int[_width * _height];

            Parallel.For(0, source.Length, _pOptions, i =>
            {
                _alpha[i] = (int)((source[i] & 0xff000000) >> 24);
                _red[i] = (source[i] & 0xff0000) >> 16;
                _green[i] = (source[i] & 0x00ff00) >> 8;
                _blue[i] = (source[i] & 0x0000ff);
            });
        }

        public Bitmap Process(int radial)
        {
            var newAlpha = new int[_width * _height];
            var newRed = new int[_width * _height];
            var newGreen = new int[_width * _height];
            var newBlue = new int[_width * _height];
            var dest = new int[_width * _height];

            Parallel.Invoke(
                () => gaussBlur_4(_alpha, newAlpha, radial),
                () => gaussBlur_4(_red, newRed, radial),
                () => gaussBlur_4(_green, newGreen, radial),
                () => gaussBlur_4(_blue, newBlue, radial));

            Parallel.For(0, dest.Length, _pOptions, i =>
            {
                if (newAlpha[i] > 255) newAlpha[i] = 255;
                if (newRed[i] > 255) newRed[i] = 255;
                if (newGreen[i] > 255) newGreen[i] = 255;
                if (newBlue[i] > 255) newBlue[i] = 255;

                if (newAlpha[i] < 0) newAlpha[i] = 0;
                if (newRed[i] < 0) newRed[i] = 0;
                if (newGreen[i] < 0) newGreen[i] = 0;
                if (newBlue[i] < 0) newBlue[i] = 0;

                dest[i] = (int)((uint)(newAlpha[i] << 24) | (uint)(newRed[i] << 16) | (uint)(newGreen[i] << 8) | (uint)newBlue[i]);
            });

            var image = new Bitmap(_width, _height);
            var rct = new Rectangle(0, 0, image.Width, image.Height);
            var bits2 = image.LockBits(rct, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            Marshal.Copy(dest, 0, bits2.Scan0, dest.Length);
            image.UnlockBits(bits2);
            return image;
        }

        private void gaussBlur_4(int[] source, int[] dest, int r)
        {
            var bxs = boxesForGauss(r, 3);
                boxBlur_4(source, dest, _width, _height, (bxs[0] - 1) / 2);
                boxBlur_4(dest, source, _width, _height, (bxs[1] - 1) / 2);
                boxBlur_4(source, dest, _width, _height, (bxs[2] - 1) / 2);
            
        }

        private int[] boxesForGauss(int sigma, int n)
        {
            var wIdeal = Math.Sqrt((12 * sigma * sigma / n) + 1);
            var wl = (int)Math.Floor(wIdeal);
            if (wl % 2 == 0) wl--;
            var wu = wl + 2;

            var mIdeal = (double)(12 * sigma * sigma - n * wl * wl - 4 * n * wl - 3 * n) / (-4 * wl - 4);
            var m = Math.Round(mIdeal);

            var sizes = new List<int>();
            for (var i = 0; i < n; i++) sizes.Add(i < m ? wl : wu);
            return sizes.ToArray();
        }

        private void boxBlur_4(int[] source, int[] dest, int w, int h, int r)
        {
            for (var i = 0; i < source.Length; i++) dest[i] = source[i];
                boxBlurH_4(dest, source, w, h, r);
                boxBlurT_4(source, dest, w, h, r);
        }

        private void boxBlurH_4(int[] source, int[] dest, int w, int h, int r)
        {
            try
            {
                var iar = (double)1 / (r + r + 1);
                Parallel.For(0, h, _pOptions, i =>
                {
                    var ti = i * w;
                    var li = ti;
                    var ri = ti + r;
                    var fv = source[ti];
                    var lv = source[ti + w - 1];
                    var val = (r + 1) * fv;
                    for (var j = 0; j < r; j++) val += source[ti + j];
                    for (var j = 0; j <= r; j++)
                    {   if (ri < source.Length)
                        val += source[ri++] - fv;
                        dest[ti++] = (int)Math.Round(val * iar);
                    }
                    for (var j = r + 1; j < w - r; j++)
                    {
                        if (ri < source.Length && ti < dest.Length)
                            val += source[ri++] - dest[li++];
                        if (ti < dest.Length)
                        dest[ti++] = (int)Math.Round(val * iar);
                    }
                    for (var j = w - r; j < w; j++)
                    {
                        if (li < source.Length)
                        val += lv - source[li++];
                        if (ti < dest.Length)
                            dest[ti++] = (int)Math.Round(val * iar);
                    }
                });
            }
            catch(Exception ex)
            {
                // Do nothing
            }
            
        }

        private void boxBlurT_4(int[] source, int[] dest, int w, int h, int r)
        {
            try
            {
                var iar = (double)1 / (r + r + 1);
                Parallel.For(0, w, _pOptions, i =>
                {
                    var ti = i;
                    var li = ti;
                    var ri = ti + r * w;
                    var fv = source[ti];
                    var lv = source[ti + w * (h - 1)];
                    var val = (r + 1) * fv;
                    for (var j = 0; j < r; j++) val += source[ti + j * w];
                    for (var j = 0; j <= r; j++)
                    {
                        if (ri < source.Length)
                        val += source[ri] - fv;
                        if (ti < dest.Length)
                        dest[ti] = (int)Math.Round(val * iar);
                        ri += w;
                        ti += w;
                    }
                    for (var j = r + 1; j < h - r; j++)
                    {
                        if (ri < source.Length && li < source.Length)
                        val += source[ri] - source[li];
                        if (ti < dest.Length)
                        dest[ti] = (int)Math.Round(val * iar);
                        li += w;
                        ri += w;
                        ti += w;
                    }
                    for (var j = h - r; j < h; j++)
                    {
                        if (li < source.Length)
                        val += lv - source[li];
                        if (ti < dest.Length)
                        dest[ti] = (int)Math.Round(val * iar);
                        li += w;
                        ti += w;
                    }
                });
            }
            catch(Exception ex)
            {
                // Do nothing
            }
            
        }
        public static System.Drawing.Color GetDominantColor(Bitmap bmp)
        {
            if (bmp == null)
            {
                throw new ArgumentNullException("bmp");
            }

            BitmapData srcData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);

            int bytesPerPixel = Image.GetPixelFormatSize(srcData.PixelFormat) / 8;

            int stride = srcData.Stride;

            IntPtr scan0 = srcData.Scan0;

            long[] totals = new long[] { 0, 0, 0 };

            int width = bmp.Width * bytesPerPixel;
            int height = bmp.Height;

            unsafe
            {
                byte* p = (byte*)(void*)scan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x += bytesPerPixel)
                    {
                        totals[0] += p[x + 0];
                        totals[1] += p[x + 1];
                        totals[2] += p[x + 2];
                    }

                    p += stride;
                }
            }

            long pixelCount = bmp.Width * height;

            int avgB = Convert.ToInt32(totals[0] / pixelCount);
            int avgG = Convert.ToInt32(totals[1] / pixelCount);
            int avgR = Convert.ToInt32(totals[2] / pixelCount);

            bmp.UnlockBits(srcData);

            return Color.FromArgb(avgR, avgG, avgB);

        }
    }
}