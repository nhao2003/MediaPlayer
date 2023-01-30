# MediaPlayer
MediaPlayer là một ứng dụng phương tiện cung cấp các chức năng tương đồng với Windows Media Player trên nền tảng Windows.

# Nguồn dữ liệu (Data source) 
- Chủ yếu là các file nhạc lưu trên ổ đĩa.
- Hỗ trợ các định dạng sau:
    - **.mp3** (music)
    - **.mp4** (video)
	
# Các tab chính trong app: 
1. **Tab Home** 
- Hiển thị các media mặc định có sẵn trên máy (dựa trên các path mặc định).
2. **Tab search**
- Cung cấp giao diện tìm kiếm media (cả music và video).
- Có thể tìm kiếm thông qua các từ khóa chỉ tên, tác giả, album của media.
3. **Tab Settings**
- Cho phép người dùng tùy ý chuyển đổi path mặc định lưu trữ để refresh lại app theo path mới, đồng thời cung cấp thông tin về nhóm.
4. **Tab Music**
- Theo mặc định, tab music hiển thị tất cả bài hát trong thư mục music mặc định (default music directory).
- Có thể sort và group lại thành nhóm theo một tiêu chí nhất định (vd: sắp xếp từ A - Z).
5. **Tab Video**
- Có cùng chức năng như **Tab Music**, nhưng tab hiển thị video thay vì music.
6. **Tab Playlist**
- Cho phép người dùng tạo cho mình các playlist riêng, lưu lại trên database và load lại cho người dùng cho các lần mở sau.
- Có thể thêm, xóa các media trong playlist và edit playlist...

# Ngôn ngữ lập trình sử dụng
**Microsoft Visual Studio C# (Winforms)**

# Một số thư viện và source code nguồn sử dụng:
- [Gaussian Blur](https://github.com/mdymel/superfastblur)
- [FFMpeg .NET wrapper](https://www.nrecosite.com/video_converter_net.aspx)
- [SQLite](nuget.org/packages/System.Data.SQLite/)
- [Taglib Sharp](https://github.com/mono/taglib-sharp)
- ...

# Nhóm thực hiện đồ án 
- **21520620 - Nguyễn Tuấn Bảo**
- **21522046 - Nguyễn Nhật Hào**
- **21522345 - Phan Văn Minh**

# Link video demo đồ án
https://drive.google.com/file/d/1T6kD7kJ-6MIKDyeTA5hq2ycp6Elf7pV9/view?usp=sharing