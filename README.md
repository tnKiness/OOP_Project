# Lập trình Hướng Đối Tượng (OOP)

## Chương trình chấm công và quản lý lương nhân viên

### 1. Mô tả và mục tiêu dự án

#### Mô tả
Chương trình **Chấm công và quản lý lương nhân viên** được phát triển bằng **C#** theo mô hình **Lập trình Hướng Đối Tượng (OOP)**, sử dụng **JSON** để lưu trữ dữ liệu nhằm đơn giản hóa việc triển khai, không yêu cầu sử dụng MySQL.

##### Chức năng chính:
- **Chấm công nhân viên:** Ghi nhận giờ vào, giờ ra theo từng ngày.
- **Tính lương tự động:** Dựa trên số công và mức lương theo từng vị trí.
- **Quản lý nhân viên:** Thêm, sửa, xóa thông tin nhân viên.
- **Phân quyền sử dụng:**
  - **Admin:** Quản lý toàn bộ hệ thống, thêm/xóa nhân viên, cập nhật lương.
  - **Nhân sự:** Theo dõi chấm công và duyệt bảng lương.
  - **Nhân viên:** Xem lịch sử chấm công và lương cá nhân.
- **Lưu trữ dữ liệu bằng JSON** thay vì MySQL để đơn giản hóa triển khai.

#### Mục tiêu
- Giúp doanh nghiệp quản lý thời gian làm việc và tính lương một cách chính xác, minh bạch.
- Giảm tải công việc thủ công và tiết kiệm thời gian xử lý dữ liệu.

### 2. Tác giả
- **Trần Nhật Khánh** - Đồng  giả: [GitHub](https://github.com/tnKiness)
- **Lê Lộc Sơn** - Đồng tác giả: [GitHub](https://github.com/SonLocLe)
- **Nguyễn Phụng Châu** - Đồng tác giả: [GitHub](https://github.com/j1mmyhvstle)

### 3. Kiến thức áp dụng
- **Lập trình Hướng Đối Tượng (OOP):** Áp dụng các nguyên tắc đóng gói, kế thừa, đa hình, trừu tượng.
- **C# với WinForms:** Xây dựng giao diện đồ họa, xử lý sự kiện và luồng nghiệp vụ.
- **Xử lý CRUD:** Thêm, sửa, xóa, tìm kiếm dữ liệu nhân viên.
- **Quản lý tệp JSON:** Lưu trữ và truy xuất dữ liệu từ tệp JSON thay vì MySQL.
- **Phân quyền người dùng:** Hạn chế quyền truy cập giữa quản trị viên, nhân sự và nhân viên.

### 4. Triển khai
- **Nền tảng:**
  - Ngôn ngữ: **C# (WinForms)**
  - Lưu trữ dữ liệu: **JSON**
  - Thư viện hỗ trợ: **Newtonsoft.Json, Bunifu UI, DevExpress**

### 5. Hướng phát triển
- Cải tiến giao diện UI/UX để tối ưu trải nghiệm người dùng.
- Hỗ trợ xuất báo cáo công và lương dưới dạng PDF/Excel.
- Tích hợp API gửi email thông báo bảng lương.
- Hỗ trợ đăng nhập bằng vân tay hoặc mã QR.

### 6. Liên kết dự án
- 🔗 **GitHub Repository**: [https://github.com/tnKiness/OOP_Project](https://github.com/tnKiness/OOP_Project)
 
