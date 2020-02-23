use TTN_QLKho
go

drop database TTN_QLKho

create table Loai(
	MaLoai varchar(8) primary key,
	TenLoai nvarchar(150) ,
	MoTa nvarchar(150)
)

create table SanPham(
	MaSP varchar(8) primary key,
	TenSP nvarchar(150) ,
	HanMucDuTru int ,
	NuocSX nvarchar(50) ,
	DVT nvarchar(30),
	DonGia decimal(18,2) ,

	MaLoai varchar(8),

	foreign key (MaLoai) references Loai(MaLoai) on delete cascade
)

create table PhieuNhap(
	MaPN varchar(8) primary key,
	NgayNhap date ,
	TongTien decimal(18,2),
	GhiChu nvarchar(200) ,

	MaNCC varchar(8),
	Id int,

	foreign key (MaNCC) references NhaCungCap(MaNCC) on delete cascade,
	foreign key (Id) references NhanVien(Id) on delete cascade
)

create table CT_PhieuNhap(
	MaSP varchar(8),
	MaPN varchar(8),
	SoLuong int ,
	DonGia decimal(18,2) ,

	primary key(MaSP, MaPN),
	foreign key (MaPN) references PhieuNhap(MaPN) on delete cascade,
	foreign key (MaSP) references SanPham(MaSP) on delete cascade
)

create table NhaCungCap(
	MaNCC varchar(8) primary key,
	TenNCC nvarchar(150) ,
	DiaChi nvarchar(150),
	DienThoai varchar(11)
)



create table KhachHang(
	MaKH varchar(8) primary key,
	HoTen nvarchar(50) 
)

create table NhanVien(
	Id int primary key identity,
	TenDN varchar(20),
	MatKhau varchar(50),
	HoTen nvarchar(50) , 
	DiaChi nvarchar(150),
	SDT varchar(10),
	NgaySinh date,
	GioiTinh bit,
	Email varchar(30),
	isActive bit,
	isAdmin bit
)

create table PhieuXuat(
	MaPX varchar(8) primary key,
	GhiChu nvarchar(200),
	TongTien decimal(18,2),
	NgayMua date,

	Id int,
	MaKH varchar(8),

	foreign key (Id) references NhanVien(Id) on delete cascade,
	foreign key (MaKH) references KhachHang(MaKH) on delete cascade
)


create table CT_PhieuXuat(
	MaPX varchar(8),
	MaSP varchar(8),
	SoLuong int,

	primary key(MaPX, MaSP),
	foreign key (MaPX) references PhieuXuat(MaPX) on delete cascade,
	foreign key (MaSP) references SanPham(MaSP) on delete cascade
)



--insert data

	
insert into Loai
values('L001',N'Điện Thoại ,LapTop' ,N'')
insert into Loai
values('L002',N'Điện Gia Dụng', N'')
insert into Loai 
values('L003',N'Phụ Kiện', N'')
insert into Loai 
values('L004',N'Thiết Bị Văn Phòng', N'')
insert into Loai 
values('L005',N'Đồ dùng Gia Đình', N'')
insert into Loai 
values('L006',N'Thuốc men , dược phẩm', N'')


insert into NhaCungCap 
values('NCC001', N'Samsung Vina Electronics', N'Tầng 25, Bitexco Financial Tower,2 Hải Triều, Quận 1, TP. Hồ Chí Minh', '1800588890')
insert into NhaCungCap 
values('NCC002', N'Công ty TNHH LG Electronics Việt Nam', N'Lô CN2, KCN Tràng Duệ, xã Lê Lợi, huyện An Dương, thành phố Hải Phòng, Việt Nam. ', '249345151')
insert into NhaCungCap 
values('NCC003', N'Công ty TNHH Panasonic Việt Nam', N'Lô J1-J2, Khu công nghiệp Thăng Long, xã Kim Chung, huyện Đông Anh, Tp. Hà Nội, Việt Nam', '0439550111 ')
insert into NhaCungCap 
values('NCC004', N'Xiaomi Việt Nam', N'Số 31L, Láng Hạ, Q. Ba Dình, Hà Nội ,Việt Nam', '0326375888')
insert into NhaCungCap 
values('NCC005', N'BlueStone VietNam', N'Tầng 3, Tòa nhà HEID, 12 Đường Láng Hạ, P. Thành Công, Q. Ba Đình, Hà Nội', '1800545494')
insert into NhaCungCap 
values('NCC006', N'Kangaroo', N'Tầng 5, Tòa nhà Ocean Park, Số 1 Đào Duy Anh, Đống Đa, Hà Nội', '36281698')
insert into NhaCungCap 
values('NCC007', N'TOSHIBA Hà Nội', N'Phòng 303, Maritime Bank Tower, 88 Láng Hạ, Q. Đống Đa, Hà Nội', '02437765955')
insert into NhaCungCap 
values('NCC008', N'OPPO VietNam', N'27 Nguyễn Trung Trực, Phường Bến Thành, Quận 1, Thành phố Hồ Chí Minh', '1800577776')
insert into NhaCungCap 
values('NCC009', N'VIVO Vietnam', N'Tầng 5 Tòa nhà Lilama 10, phố Tố Hữu, Phường Trung Văn, Quận Nam Từ Liêm, TP. Hà Nội', '18006101')
insert into NhaCungCap 
values('NCC010', N'CÔNG TY TNHH ĐIỆN MÁY AQUA VIỆT NAM', N'Tầng 16, Tòa nhà Detech II, 107 Nguyễn Phong Sắc, Cầu Giấy, Hà Nội', '02838229981')
insert into NhaCungCap 
values('NCC011', N'Asus Việt Nam', N'292, Đường Tây Sơn, Trung Liệt, Đống Đa, Hà Nội', '18006588')
insert into NhaCungCap 
values('NCC012', N'BeKo HaNoi', N'63 Trần Quang Diệu, Phường Ô Chợ Dừa, Đống Đa, Hà Nội', '18006398')
insert into NhaCungCap 
values('NCC013', N'Công Ty Ld Sony Việt Nam - Cn Hà Nội', N'300 Trần Khát Chân, Thanh Nhàn, Hai Bà Trưng, Hà Nội', '039723038')
insert into NhaCungCap 
values('NCC014', N'Công Ty Tnhh Candy Việt Nam', N'29 Phố Nguyễn Thị Định, Trung Hoà, Cầu Giấy, Hà Nội', '')
insert into NhaCungCap 
values('NCC015', N'Bosch Việt Nam tại Hà Nội', N'Lô 03C, Tầng 2, Trung tâm Quốc tế 17 Ngô Quyền, Quận Hoàn Kiếm , Hà Nội, Việt Nam', '039393119')
insert into NhaCungCap 
values('NCC016', N'Công Ty Điện Tử Sharp Việt Nam', N'Tầng 5, Charmvit Tower, 117, Trần Duy Hưng, Trung Hòa, Cầu Giấy, Hà Nội', '035560797')
insert into NhaCungCap 
values('NCC017', N'Công ty Cổ phần Casper Việt Nam', N'Biệt thự số B12A-12B, Khu Vinhomes Gardenia, Hàm Nghi, Cầu Diễn, Từ Liêm, Hà Nội', '18006644')
insert into NhaCungCap 
values('NCC018', N'Công Ty TNHH Skyworth Việt Nam', N'Tầng 17 - Tòa nhà Petroland Số 12 Tân Trào, Phường Tân Phú, Quận 07, TP HCM', '18001180')
insert into NhaCungCap 
values('NCC019', N'Công Ty Ariston Thermo Việt Nam', N' Tầng 8, Tòa nhà Hanoi Tourist, 18, Đường Lý Thường Kiệt, Quận Hoàn Kiếm, Hàng Bài, Hoàn Kiếm, Hà Nội', '02438586655')
insert into NhaCungCap 
values('NCC020', N'Ferroli Việt Nam', N'HD Mon, TT04-17, Nam Từ Liêm, Hà nội', '02433927957')
insert into NhaCungCap 
values('NCC021', N'HP VietNam', N'Unit 1002B, 10th Floor, 521 Kim Ma St Handi Resco Towers', '')
insert into NhaCungCap 
values('NCC022', N'DaiKin', N'Level 2, PVV Building, Nam Cuong Urban Area, 234 Hoang Quoc Viet Street, Bac Tu Liem District, Ha Noi City', '02422091111')
insert into NhaCungCap 
values('NCC023', N'Huawei Technologies Vietnam Co., Ltd', N'Keangnam Landmark, E6, Phạm Hùng, Mễ Trì, Nam Từ Liêm, Hà Nội', '02435538000')
insert into NhaCungCap 
values('NCC024', N'Tổng công ty dược Việt nam', N'138B Giảng Võ - Ba Đình - Hà Nội.', '38443151')
insert into NhaCungCap 
values('NCC025', N'Công ty cổ phần Thương mại và Dược phẩm Trúc Tâm', N' Số 6 Ngách 560/56 Nguyễn Văn Cừ - Long Biên - Hà Nội', '04.36524112')
insert into NhaCungCap 
values('NCC026', N'Công ty TNHH Tuệ Linh', N'Số 36, lô M2, KĐT Yên Hòa - Cầu Giấy - Hà Nội.', '0435568112')
insert into NhaCungCap 
values('NCC027', N'Công ty TNHH Dược và thiết bị Y tế Việt Mỹ', N' 2/4 Nguyễn Đình Chiểu, Hà Nội, Việt Nam.', '8449745166')
insert into NhaCungCap 
values('NCC028', N'Công ty Cổ phần Dược phẩm Việt Đức', N' Lô B10/D6 - Khu đô thị Cầu Giấy, phường Dịch Vọng, quận Cầu Giấy, Hà Nội.', '0435148042')
insert into NhaCungCap 
values('NCC029', N'Công ty cổ phấn y dược phẩm VIMEDIMEX', N'246 Cống Quỳnh, P. Phạm Ngũ Lão, Q.1, Tp.HCM', '0838990164')
insert into NhaCungCap 
values('NCC030', N'Công ty Cổ phần Dược phẩm Vinacare', N'Số 18 ngách 19/15 Kim Đồng- Hà Nội', '0436649263')




insert into SanPham 
values('SP001', N'c', 10, N'', N'', 12, 'L001')



insert into CT_PhieuNhap 
values('SP001', 'PN001', 50, 450000)




insert into PhieuNhap 
values()


/*
insert into PhieuXuat
values(MaPX ,GhiChu , TongTien ,NgayMua ,TenDN , MaKH )
*/

insert into PhieuXuat
values()

insert into CT_PhieuXuat
values()


/*
nhanvien(tendangnhap , matkhau, hoten ,diachi ,sdt , ngaysinh , gioitinh, email)
*/
/*
insert into NhanVien 
values('NV002', N'Nguyễn Thị Ngọc Huyền', N'Số 13B, Ngõ 61/16 Lạc Trung, P. Vinh Tuy, Q. Hai Bà Trưng, Hà Nội', '0954872165', '2000-10-23', 5000000, 6)
insert into NhanVien 
values('NV003', N'Lê Huỳnh', N'Số 41, Ngõ 6, Đường 800A, Nghĩa Đô, Cầu Giấy, Hà Nội', '0965873251', '1997-2-21', 4500000, 4)
insert into NhanVien 
values('NV004', N'Nguyễn Thị Nụ', N'Số 45 Tổ 60 Phố Trung Kính, P. Yên Hòa, Q. Cầu Giấy, Hà Nội', '0954533548', '2005-6-12', 2500000, 8)
insert into NhanVien 
values('NV005', N'Trần Huyền Trang', N'7 Ngõ 39/1, Pháo Đài Láng, Láng Thượng, Q. Đống Đa, Hà Nội', '0958216538', '1998-3-10', 3000000, 10)
*/

insert into KhachHang 
values('KH001', N'Mguyễn Thị Hồng Nhung')
insert into KhachHang 
values('KH002', N'Phạm Cẩm Ly')
insert into KhachHang 
values('KH003', N'Trần Kháng Ly')
insert into KhachHang 
values('KH004', N'Lương Hồng Hạnh')
insert into KhachHang 
values('KH005', N'Phạm Quang Minh')
insert into KhachHang 
values('KH006', N'Trần Thị Xuyên')
insert into KhachHang 
values('KH007', N'Cao Thị Mỹ Duyên')

SELECT * FROM LOAI

--TẠO THỦ TỤC XEM CHI TIẾT 1 SẢN PHẨM
ALTER PROC XEMCHITIETSANPHAM(@MA VARCHAR(10))AS
BEGIN
	SELECT * FROM SanPham
	WHERE @MA=MaSP
END
XEMCHITIETSANPHAM 'SP001'

-- TẠO THỦ TỤC XEM TẤT CẢ SẢN PHẨM.
CREATE PROC XEMTATCASANPHAM AS
BEGIN
	SELECT * FROM SanPham
END
XEMTATCASANPHAM

-- TAO THU TUC THEM SAN PHAM 
CREATE PROC THEMSANPHAM (@MA VARCHAR(10) , @TEN nvarchar(50) , @DUTRU INT ,  @XUATXU CHAR(20) ,
@DONVITINH NVARCHAR(30),@DONGIA DECIMAL(18,2),@MALOAI Varchar(8))
AS
BEGIN
	INSERT INTO SanPham(MaSP ,TenSP ,HanMucDuTru ,NuocSX ,DVT ,DonGia ,MaLoai )
	VALUES (@MA ,@ten ,@DUTRU ,@XUATXU ,@DONVITINH ,@DONGIA ,@MALOAI )
END



THEMSANPHAM 'SP001','DÂU GIÓ','600','VIET NAM','CHAI','28000','Loai0001'
THEMSANPHAM 'SP002','TIVI SAMSUNG UA 43 INCH','200','VIET NAM','CHIẾC','8590000','Loai003'
THEMSANPHAM 'SP003','TỦ LẠNH SAMSUNG RTSV','600','VIET NAM','CHIẾC','6500000','Loai0002'
THEMSANPHAM 'SP004','TỦ LẠNH SAMSUNG RSSV 560L','600','THÁI LAN','CHAI','29280000','Loai0002'
THEMSANPHAM 'SP005','TỦ LẠNH SAMSUNG RBSV 276 L','600','VIET NAM','CHAI','18000000','Loai0002'
THEMSANPHAM 'SP006','TIVI SONY KD 55 inch','600','VIET NAM','CHAI','22000000','Loai0002'
THEMSANPHAM 'SP007','DÂU GIÓ','600','VIET NAM','CHAI','28000','L006'
THEMSANPHAM 'SP008','DÂU GIÓ','600','VIET NAM','CHAI','28000','L006'
THEMSANPHAM 'SP009','DÂU GIÓ','600','VIET NAM','CHAI','28000','L006'
THEMSANPHAM 'SP010','DÂU GIÓ','600','VIET NAM','CHAI','28000','L006'
THEMSANPHAM 'SP011','DÂU GIÓ','600','VIET NAM','CHAI','28000','L006'
THEMSANPHAM 'SP012','DÂU GIÓ','600','VIET NAM','CHAI','28000','L006'

-- TAO THU TUC SUA SAN PHAM 
CREATE PROC SUASANPHAM (@MA VARCHAR(10) , @TEN nvarchar(50) , @DUTRU INT ,  @XUATXU CHAR(20) ,
@DONVITINH NVARCHAR(30),@DONGIA DECIMAL(18,2),@MALOAI Varchar(8))
AS
BEGIN
	UPDATE SanPham
	SET TenSP = @TEN , HanMucDuTru = @DUTRU , NuocSX = @XUATXU , DVT = @DONVITINH , DonGia = @DONGIA , MaLoai = @MALOAI
	where MaSP = @MA
END

SUASANPHAM 'SP001','DÂU GIÓ','800','VIET NAM','CHAI','28000','L006'

--tao thu tuc xóa 1 sản phẩm.
CREATE PROC XOASANPHAM(@MA VARCHAR(10))AS
BEGIN 
	DELETE FROM SanPham
	WHERE MaSP = @MA
END

XOASANPHAM 'SP001'

----------------------------------------------------------------------------------------------------------------

-- TAO THU TUC THEM HANG
CREATE PROC THEMHANGVAOPHIEUNHAP (@MAPN VARCHAR(8) ,@MASP VARCHAR(8), @NGAYNHAP DATE , @TONGTIEN DECIMAL(18,2),
@GHICHU NVARCHAR(200) ,@MANHACUNGCAP VARCHAR(8) ,@SOLUONG INT , @DONGIA DECIMAL(18,2), @ID int )
AS
BEGIN
	INSERT INTO PhieuNhap(MaPN ,NgayNhap ,TongTien ,GhiChu ,MaNCC ,Id )
	VALUES (@MAPN ,@NGAYNHAP ,@TONGTIEN ,@GHICHU ,@MANHACUNGCAP ,@ID )
	INSERT INTO CT_PhieuNhap(MaSP ,MaPN ,SoLuong ,DonGia)
	VALUES (@MASP ,@MAPN ,@SOLUONG ,@DONGIA)
END


--TẠO THỦ TỤC XEM CHI TIẾT 1 PHIEU NHAP
CREATE PROC XEMCHITIETPHIEUNHAP(@MA VARCHAR(10))AS
BEGIN
	SELECT PhieuNhap.MaPN, NgayNhap, TongTien, GhiChu, MaNCC, Id,  MaSP,
	SoLuong , DonGia FROM PhieuNhap ,CT_PhieuNhap
	WHERE @MA=PhieuNhap.MaPN
END

-- TẠO THỦ TỤC XEM TẤT CẢ HANG NHAP
CREATE PROC XEMTATCAPHIEUNHAP AS
BEGIN
	SELECT * FROM PHIEUNHAP , CT_PHIEUNHAP
END

-- TAO THU TUC SUA phieu nhap 
CREATE PROC SUAPHIEUNHAP (@MAPN VARCHAR(8),@NGAYNHAP DATE,@TONGTIEN INT,@GHICHU NVARCHAR(200),
@MANHACUNGCAP VARCHAR(8),@ID int)
AS
BEGIN
	UPDATE PhieuNhap
	SET NgayNhap = @NGAYNHAP , TongTien = @TONGTIEN , GhiChu=@GHICHU ,MaNCC = @MANHACUNGCAP , Id=@ID
	where MaPN = @MAPN
END

-- TAO THU TUC SUA chi tiet phieu nhap 
CREATE PROC SUACT_PHIEUNHAP (@MASP VARCHAR(8) ,@MAPN VARCHAR(8) ,@SOLUONG INT ,@DONGIA DECIMAL(18,2))
AS
BEGIN
	UPDATE CT_PhieuNhap
	SET MaSP=@MASP ,SoLuong=@SOLUONG ,DonGia=@DONGIA
	where MaPN = @MAPN
END

--tao thu tuc xóa 1 sản phẩm.
CREATE PROC XOAPN(@MAPN VARCHAR(8))AS
BEGIN 
	DELETE FROM PhieuNhap
	WHERE MaPN = @MAPN
	DELETE FROM CT_PhieuNhap
	WHERE MaPN = @MAPN
END


------------------------------------------------------------------------------------------------------------------
--THEM NHAN VIEN 
create PROC THEMNHANVIEN(@TENDN VARCHAR(20), @MATKHAU VARCHAR(50),@HOTEN NVARCHAR(50),
@DIACHI NVARCHAR(50) , @SDT VARCHAR(10) ,@NGAYSINH DATE, @GIOITINH BIT , @EMAIL VARCHAR(30), @ISACTIVE bit, @ISADMIN bit)AS
BEGIN
	INSERT INTO NhanVien(TenDN ,MatKhau ,Hoten ,DiaChi ,SDT ,NgaySinh ,GioiTinh ,Email, isActive, isAdmin )
	Values(@TENDN ,@MATKHAU ,@HOTEN ,@DIACHI ,@SDT ,@NGAYSINH ,@GIOITINH ,@EMAIL, @ISACTIVE, @ISADMIN )
END

alter table NhanVien add isActive bit
select * from NhanVien
update NhanVien set isActive = 1

select * from SanPham
select * from PhieuNhap
select * from CT_PhieuNhap
delete from CT_PhieuNhap where MaSP = 'PN001'
--SUA THONG TIN NHAN VIEN
CREATE PROC SUATHONGTINNHANVIEN(@ID int, @TENDN VARCHAR(20), @MATKHAU VARCHAR(50),@HOTEN NVARCHAR(50),
@DIACHI NVARCHAR(50) , @SDT VARCHAR(10) ,@NGAYSINH DATE, @GIOITINH BIT , @EMAIL VARCHAR(30), @ISACTIVE bit, @ISADMIN bit )AS
BEGIN
	UPDATE NhanVien
	SET TenDN=@TENDN ,MatKhau=@MATKHAU ,Hoten=@HOTEN ,DiaChi=@DIACHI ,SDT=@SDT ,
		NgaySinh=@NGAYSINH ,GioiTinh =@GIOITINH ,Email = @EMAIL, isActive = @ISACTIVE, isAdmin = @ISADMIN 
	WHERE Id = @ID
END
-- XOA THONG TIN NHAN VIEN
CREATE PROC XOANHANVIEN(@ID int)AS
BEGIN
	DELETE FROM NhanVien
	WHERE Id = @ID
END

--XEM THONG TIN NHAN VIEN
create PROC XEMTATCANHANVIEN AS
BEGIN
	SELECT * FROM NhanVien where isActive = 1
END

CREATE PROC XEMCHITIETNHANVIEN(@ID int) AS
BEGIN
	SELECT * FROM NhanVien
	WHERE Id = @ID
END
XEMCHITIETNHANVIEN 'phamtrunghieu'

------------------------------------------------------------------------------------------------------------------

--THEM KHACH HANG
CREATE PROC THEMKHACHHANG(@MAKH VARCHAR(8) , @TENKHACH NVARCHAR(50))AS
BEGIN
	INSERT INTO KhachHang (MaKH , HoTen)
	Values (@MAKH,@TENKHACH)
END

--SUA THONG TIN KHACH HANG
CREATE PROC SUATHONGTINKHACHHANG(@MAKH VARCHAR(8),@TENKHACH NVARCHAR(50))AS
BEGIN
	UPDATE KhachHang 
	SET MaKH =@MAKH , HoTen = @TENKHACH
	WHERE MaKH =@MAKH 
END
-- XOA THONG TIN KHACH HANG
CREATE PROC XOAKHACHHANG(@MAKH VARCHAR(8))AS
BEGIN
	DELETE FROM KhachHang
	WHERE MaKH = @MAKH
END

--XEM THONG TIN KHACH HANG 
CREATE PROC XEMTATCAKHACHHANG AS
BEGIN
	SELECT * FROM KhachHang
END

CREATE PROC XEMCHITIETKHACHHANG(@MAKH VARCHAR(8)) AS
BEGIN
	SELECT * FROM KhachHang
	WHERE MaKH =@MAKH
END
XEMCHITIETKHACHHANG 'KH002'

------------------------------------------------------------------------------------------------------------------


-- TAO THU TUC XUAT HANG
CREATE PROC THEMHANGVAOPHIEUXUAT (@MAPX VARCHAR(8) ,@MASP VARCHAR(8),@GHICHU NVARCHAR(200),@SOLUONG INT ,@TONGTIEN DECIMAL(18,2),
@NGAYMUA DATE ,@TENDANGNHAP VARCHAR(20) , @MAKH VARCHAR(8) )
AS
BEGIN
	INSERT INTO PhieuXuat(MaPX ,GhiChu ,TongTien ,NgayMua ,TenDN ,MaKH)
	VALUES (@MAPX ,@GHICHU ,@TONGTIEN , @NGAYMUA ,@TENDANGNHAP , @MAKH)
	INSERT INTO CT_PhieuXuat(MaPX ,MaSP ,SoLuong )
	VALUES (@MAPX ,@MASP ,@SOLUONG )
END


--TẠO THỦ TỤC XEM CHI TIẾT 1 PHIEU NHAP
CREATE PROC XEMCHITIETPHIEUXUAT(@MAPX VARCHAR(8))AS
BEGIN
	SELECT PhieuXuat.MaPX,GhiChu ,TongTien ,NgayMua ,TenDN ,MaKH,MaSP ,SoLuong
	FROM PhieuXuat ,CT_PhieuXuat
	WHERE @MAPX=PhieuXuat.MaPX
END

-- TẠO THỦ TỤC XEM TẤT CẢ HANG XUAT
CREATE PROC XEMTATCAPHIEUXUAT AS
BEGIN
	SELECT * FROM PHIEUXUAT , CT_PHIEUXUAT
END

-- TAO THU TUC SUA phieu XUAT
CREATE PROC SUAPHIEUXUAT (@MAPX VARCHAR(8),@GHICHU NVARCHAR(200),@TONGTIEN DECIMAL(18,2),
@NGAYMUA DATE ,@TENDANGNHAP VARCHAR(20) , @MAKH VARCHAR(8))
AS
BEGIN
	UPDATE PhieuXuat
	SET MaPX=@MAPX ,GhiChu=@GHICHU ,TongTien =@TONGTIEN ,
		NgayMua=@NGAYMUA ,TenDN=@TENDANGNHAP  ,MaKH= @MAKH 
	where MaPX = @MAPX
END

-- TAO THU TUC SUA chi tiet phieu XUAT 
CREATE PROC SUACT_PHIETXUAT (@MAPX VARCHAR(8) ,@MASP VARCHAR(8) ,@SOLUONG INT )
AS
BEGIN
	UPDATE CT_PhieuXUAT
	SET MaPX=@MAPX ,MaSP=@MASP ,SoLuong=@SOLUONG 
	where MaPX=@MAPX
END

--tao thu tuc xóa 1
CREATE PROC XOAPX(@MAPX VARCHAR(8))AS
BEGIN 
	DELETE FROM PhieuXuat
	WHERE MaPX = @MAPX
	DELETE FROM CT_PhieuXuat
	WHERE MaPX = @MAPX
END

CREATE PROC THEMNHACUNGCAP (@MANCC VARCHAR(8),@TENNCC NVARCHAR(150),@DIACHI NVARCHAR(150) ,@SDT VARCHAR(11))AS
BEGIN 
	INSERT INTO NhaCungCap(MaNCC,TenNCC,DiaChi, DienThoai)
	values(@MANCC,@TENNCC,@DIACHI,@SDT)
END

Create proc XEMNHACUNGCAP AS
BEGIN
	SELECT * FROM NhaCungCap
END

create proc XEMCHITIETNHACUNGCAP(@MANCC VARCHAR(8))AS
BEGIN
	SELECT * FROM NhaCungCap
	WHERE MaNCC = @MANCC
END

XEMCHITIETNHACUNGCAP 'NCC001'


create proc SUANHACUNGCAP(@MANCC VARCHAR(8),@TENNCC NVARCHAR(150),@DIACHI NVARCHAR(150) ,@SDT VARCHAR(11))AS
BEGIN
	UPDATE NhaCungCap
	SET MaNCC=@MANCC,TenNCC=@TENNCC,DiaChi=@DIACHI, DienThoai=@SDT
	WHERE  MaNCC=@MANCC
END

CREATE PROC XOANHACUNGCAP(@MANCC VARCHAR(8))AS
BEGIN 
	DELETE FROM NhaCungCap
	WHERE  MaNCC=@MANCC
END

with NhaCungCap as (
	select ROW_Number() Over (Order by MaNCC asc) as
	rownum,MaNCC,TenNCC,DiaChi, DienThoai 
	from NhaCungCap
)

select *from NhaCungCap
where rownum>=1 and rownum <=4




alter PROCEDURE Pagination
 @page INT,
 @size INT,
 @totalrow INT  OUTPUT
AS
BEGIN
    DECLARE @offset INT
    DECLARE @newsize INT
    DECLARE @sql NVARCHAR(MAX)

    IF(@page=0)
      BEGIN
        SET @offset = @page
        SET @newsize = @size
       END
    ELSE 
      BEGIN
        SET @offset = @page*@size
        SET @newsize = @size-1
      END
    SET NOCOUNT ON
    SET @sql = '
    with NhaCungCap as (
	select ROW_Number() Over (Order by MaNCC asc) as
	rownum,MaNCC,TenNCC,DiaChi, DienThoai 
	from NhaCungCap
	)
  select *from NhaCungCap
	where rownum>=1 and rownum <=4 ' 
   EXECUTE (@sql)
   SET @totalrow = (SELECT COUNT(*) FROM NhaCungCap)
END


Pagination '0', '4' ,'30'