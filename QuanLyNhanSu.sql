-----------   MTAZERO -------------
GO
	USE MASTER
GO
	DROP DATABASE QUANLYNHANSU
GO
	CREATE DATABASE QUANLYNHANSU
GO
	USE QUANLYNHANSU
GO
	-- TAO CAC BANG --
		CREATE TABLE ACCOUNT(
		USERNAME VARCHAR(50) PRIMARY KEY,
		PASSWORD VARCHAR(50) NOT NULL,
		TYPE VARCHAR(50)
	)
GO
	CREATE TABLE CHUCVU(
		CHUCVUID INT IDENTITY PRIMARY KEY,
		TEN NVARCHAR(MAX)
	)
GO
	CREATE TABLE PHONGBAN(
		PHONGBANID INT IDENTITY PRIMARY KEY,
		TEN VARCHAR(MAX)
	)
GO
	CREATE TABLE LUONG(
		LUONGID INT IDENTITY PRIMARY KEY,
		HESOLUONG FLOAT,
		HESOCHUCVU FLOAT,
		HESOTRACHNHIEN FLOAT,
		HESOPHUCAP FLOAT,
		HESOKHAC FLOAT
	)
GO
	CREATE TABLE NHANVIEN(
		-- NHAN VIEN PHAI LON HON 16 TUOI --
		NHANVIENID INT IDENTITY PRIMARY KEY,
		HOTEN NVARCHAR(MAX) NOT NULL,
		BIDANH NVARCHAR(MAX),
		DIACHI NVARCHAR(MAX) NOT NULL,
		NGAYSINH DATE NOT NULL,
		MASOTHUE NCHAR(15),
		GIOITINH INT, -- 0: NU, 1: NAM
		SOTKNGANHANG NCHAR(15),
		SDT NCHAR(15),
		EMAIL NVARCHAR(MAX),
		CHUCVUID INT,
		PHONGBANID INT,
		FOREIGN KEY (CHUCVUID) REFERENCES CHUCVU(CHUCVUID),
		FOREIGN KEY (PHONGBANID) REFERENCES PHONGBAN(PHONGBANID)
	) 
GO
	CREATE TABLE CMND(
		CMTID INT IDENTITY PRIMARY KEY,
		SOCMT NCHAR(15),
		NGAYCAP DATE,
		NOICAP NVARCHAR(MAX),
		NHANVIENID INT,
		FOREIGN KEY (NHANVIENID) REFERENCES NHANVIEN(NHANVIENID)
	)
GO
	CREATE TABLE HOCHIEU(
		HOCHIEUID INT IDENTITY PRIMARY KEY,
		SOHOCHIEU NCHAR(15),
		NGAYCAP DATE,
		NOICAP NVARCHAR(MAX),
		NHANVIENID INT,
		FOREIGN KEY (NHANVIENID) REFERENCES NHANVIEN(NHANVIENID)
	)
GO
	CREATE TABLE BANGCAP(
		BANGCAPID INT IDENTITY PRIMARY KEY,
		TRINHDOHOCVAN NVARCHAR(MAX),
		NHANVIENID INT,
		THOIGIAN DATE, -- THOI GIAN LAY BANG
		CHITIETBANGCAP NVARCHAR(MAX)
	)
GO
	CREATE TABLE HOPDONGLAODONG(
		HOPDONGLAODONGID INT IDENTITY PRIMARY KEY,
		NGAYKY DATE,
		LOAIHOPDONG NVARCHAR(MAX),
		LUONGID INT,-- LOAI LUONG
		NHANVIENID INT,
		FOREIGN KEY (LUONGID) REFERENCES LUONG(LUONGID)
	)
GO
	CREATE TABLE BAOHIEMXAHOI(
		BAOHIEMXAHOIID INT IDENTITY PRIMARY KEY,
		NHANVIENID INT, 
		SOTIEN INT,
		NGAYNOP DATE,
		FOREIGN KEY (NHANVIENID) REFERENCES NHANVIEN(NHANVIENID)
	)
GO
	CREATE TABLE BAOHIEMYTE(
		BAOHIEMYTEID INT IDENTITY PRIMARY KEY,
		NHANVIENID INT,
		SOTHE NCHAR(15),
		NGAYNOP DATE, -- NGAY NOP GAN NHAT
		FOREIGN KEY (NHANVIENID) REFERENCES NHANVIEN(NHANVIENID)
	)
GO
	CREATE TABLE QUATRINHCONGTAC(
		QUATRINHCONGTACID INT IDENTITY PRIMARY KEY,
		NHANVIENID INT,
		THOIGIANBATDAU DATE,
		THOIGIANKETTHUC DATE,
		NOIDUNGCONGTAC NVARCHAR(MAX),
		FOREIGN KEY (NHANVIENID) REFERENCES NHANVIEN(NHANVIENID)
	)
GO
	CREATE TABLE QUATRINHHOCTAP(
		QUATRINHOCTAPID INT IDENTITY PRIMARY KEY,
		NHANVIENID INT,
		THOIGIANBATDAU DATE,
		THOIGIANKETTHUC DATE,
		NOIDUNGHOCTAP NVARCHAR(MAX),
		FOREIGN KEY (NHANVIENID) REFERENCES NHANVIEN(NHANVIENID)
	)
GO
	CREATE TABLE THANNHAN(
		THANNHANID INT IDENTITY PRIMARY KEY,
		HOTEN NVARCHAR(MAX),
		GIOITINH INT, -- O: NU, 1: NAM
		CHUCVUID INT, -- NEU CO
		NHANVIENID INT,
		FOREIGN KEY (NHANVIENID) REFERENCES NHANVIEN(NHANVIENID)
	)
GO
	CREATE TABLE THONGTINDANG(
		THONGTINDANGID INT IDENTITY PRIMARY KEY,
		NHANVIENID INT,
		NGAYKETNAP DATE,
		NGAYRAKHOIDANG DATE 
		FOREIGN KEY (NHANVIENID) REFERENCES NHANVIEN(NHANVIENID)
	)
GO
	CREATE TABLE KHENTHUONGKYLUAT(
		KHENTHUONGKYLUATID INT IDENTITY PRIMARY KEY,
		NHANVIENID INT,
		HINHTHUC INT, -- 0: KY LUAT, 1: KHENTHUONG
		NOIDUNG NVARCHAR(MAX),
		THOIGIAN DATE,
		FOREIGN KEY (NHANVIENID) REFERENCES NHANVIEN(NHANVIENID)
	)
GO
	CREATE TABLE TAISAN(
		TAISANID INT IDENTITY PRIMARY KEY,
		NHANVIENID INT,
		TEN NVARCHAR(MAX),
		GHICHU NVARCHAR(MAX),
		FOREIGN KEY (NHANVIENID) REFERENCES NHANVIEN(NHANVIENID)
	)
GO
	CREATE TABLE CHAMCONG(
		CHAMCONGID INT IDENTITY PRIMARY KEY,
		NHANVIENID INT,
		NGAY DATE,
		LOAI INT, -- 1: LA NGAY LAM BINH THUONG, 2: LA NGAY TRUC
	)
GO
	CREATE TABLE GIOITINH(
		GIOITINHID INT PRIMARY KEY,
		TEN NVARCHAR(20)
	)
GO
	--- THEM DU LIEU ---
	INSERT INTO ACCOUNT(USERNAME, PASSWORD, TYPE) VALUES('admin', 1, 'admin')
	GO
	INSERT INTO ACCOUNT(USERNAME, PASSWORD, TYPE) VALUES('User', 0, 'User')
	GO



	INSERT INTO NHANVIEN(HOTEN,BIDANH,DIACHI,NGAYSINH,MASOTHUE,GIOITINH,SOTKNGANHANG,SDT,EMAIL,CHUCVUID,PHONGBANID)
	VALUES('AAA', 'BBB', 'HA NOI', '20170705', 1, 1, 'MBBANK', '01643861996', 'DIAGRU2510@GMAIL.COM', NULL, NULL)
	GO
	INSERT INTO NHANVIEN(HOTEN,BIDANH,DIACHI,NGAYSINH,MASOTHUE,GIOITINH,SOTKNGANHANG,SDT,EMAIL,CHUCVUID,PHONGBANID)
	VALUES('AAA', 'BBB', 'HA NOI', '20170705', 1, 1, 'MBBANK', '01643861996', 'DIAGRU2510@GMAIL.COM', 1, 1)
	GO
	INSERT INTO NHANVIEN(HOTEN,BIDANH,DIACHI,NGAYSINH,MASOTHUE,GIOITINH,SOTKNGANHANG,SDT,EMAIL,CHUCVUID,PHONGBANID)
	VALUES('AAA', 'BBB', 'HA NOI', '20170705', 1, 1, 'MBBANK', '01643861996', 'DIAGRU2510@GMAIL.COM', 1, 1)
	GO
	INSERT INTO NHANVIEN(HOTEN,BIDANH,DIACHI,NGAYSINH,MASOTHUE,GIOITINH,SOTKNGANHANG,SDT,EMAIL,CHUCVUID,PHONGBANID)
	VALUES('AAA', 'BBB', 'HA NOI', '20170705', 1, 1, 'MBBANK', '01643861996', 'DIAGRU2510@GMAIL.COM', 1, 1)
	GO
	INSERT INTO NHANVIEN(HOTEN,BIDANH,DIACHI,NGAYSINH,MASOTHUE,GIOITINH,SOTKNGANHANG,SDT,EMAIL,CHUCVUID,PHONGBANID)
	VALUES('AAA', 'BBB', 'HA NOI', '20170705', 1, 1, 'MBBANK', '01643861996', 'DIAGRU2510@GMAIL.COM', 1, 1)
	GO
	INSERT INTO NHANVIEN(HOTEN,BIDANH,DIACHI,NGAYSINH,MASOTHUE,GIOITINH,SOTKNGANHANG,SDT,EMAIL,CHUCVUID,PHONGBANID)
	VALUES('AAA', 'BBB', 'HA NOI', '20170705', 1, 1, 'MBBANK', '01643861996', 'DIAGRU2510@GMAIL.COM', 1, 1)
	GO
	INSERT INTO NHANVIEN(HOTEN,BIDANH,DIACHI,NGAYSINH,MASOTHUE,GIOITINH,SOTKNGANHANG,SDT,EMAIL,CHUCVUID,PHONGBANID)
	VALUES('AAA', 'BBB', 'HA NOI', '20170705', 1, 1, 'MBBANK', '01643861996', 'DIAGRU2510@GMAIL.COM', 1, 1)
	GO
	INSERT INTO NHANVIEN(HOTEN,BIDANH,DIACHI,NGAYSINH,MASOTHUE,GIOITINH,SOTKNGANHANG,SDT,EMAIL,CHUCVUID,PHONGBANID)
	VALUES('AAA', 'BBB', 'HA NOI', '20170705', 1, 1, 'MBBANK', '01643861996', 'DIAGRU2510@GMAIL.COM', 1, 1)
	GO
GO
	--- THEM FUNCTION TRIGGER -- 
	CREATE PROC INSERTPHONGBAN
	@TENPB NVARCHAR(MAX)
	AS
	BEGIN
		INSERT INTO PHONGBAN(TEN) VALUES(@TENPB)
	END
	GO

	CREATE PROC UPDATEPHONGBAN
	@IDPB INT, @TENPB NVARCHAR(MAX)
	AS
	BEGIN
		UPDATE PHONGBAN SET TEN = @TENPB WHERE PHONGBANID = @IDPB
	END
	GO

	CREATE PROC DELETEPHONGBAN
	@IDPB INT
	AS
	BEGIN
		DELETE PHONGBAN WHERE PHONGBANID = @IDPB
	END
	GO

	CREATE PROC INSERTCHUCVU
	@TENCV NVARCHAR(MAX)
	AS
	BEGIN
		INSERT INTO CHUCVU(TEN) VALUES(@TENCV)
	END
	GO

	CREATE PROC UPDATECHUCVU
	@IDCV INT, @TENCV NVARCHAR(MAX)
	AS
	BEGIN
		UPDATE CHUCVU SET TEN = @TENCV WHERE CHUCVUID = @IDCV
	END
	GO

	CREATE PROC DELETECHUCVU
	@IDCV INT
	AS
	BEGIN
		DELETE CHUCVU WHERE CHUCVUID = @IDCV
	END
	GO

	CREATE PROC INSERTBAOHIEMYTE
	@IDNV INT, @SOTHE NCHAR(15), @NGAYNOP DATE
	AS
	BEGIN
		INSERT INTO BAOHIEMYTE(NHANVIENID, SOTHE, NGAYNOP) VALUES(@IDNV, @SOTHE, @NGAYNOP)
	END
	GO

	CREATE PROC UPDATEBAOHIEMYTE
	@IDBAOHIEM INT, @IDNV INT, @SOTHE NCHAR(15), @NGAYNOP DATE
	AS
	BEGIN
		UPDATE BAOHIEMYTE SET NHANVIENID = @IDNV, SOTHE = @SOTHE, NGAYNOP = @NGAYNOP
		WHERE BAOHIEMYTEID = @IDBAOHIEM
	END
	GO

	CREATE PROC DELETEBAOHIEMYTE
	@IDBAOHIEM INT
	AS
	BEGIN
		DELETE BAOHIEMYTE WHERE BAOHIEMYTEID = @IDBAOHIEM
	END
	GO

	CREATE PROC INSERTBAOHIEMXAHOI
	@IDNV INT, @SOTIEN INT, @NGAYNOP DATE
	AS
	BEGIN
		INSERT INTO BAOHIEMXAHOI(NHANVIENID, SOTIEN, NGAYNOP) VALUES(@IDNV, @SOTIEN, @NGAYNOP)
	END
	GO

	CREATE PROC UPDATEBAOHIEMXAHOI
	@IDBAOHIEM INT, @IDNV INT, @SOTIEN INT, @NGAYNOP DATE
	AS
	BEGIN
		UPDATE BAOHIEMXAHOI SET NHANVIENID = @IDNV, SOTIEN = @SOTIEN, NGAYNOP = @NGAYNOP
		WHERE BAOHIEMXAHOIID = @IDBAOHIEM
	END
	GO

	CREATE PROC DELETEBAOHIEMXAHOI
	@IDBAOHIEM INT
	AS
	BEGIN
		DELETE BAOHIEMXAHOI WHERE BAOHIEMXAHOIID = @IDBAOHIEM
	END
	GO

	CREATE PROC INSERTHOPDONGLAODONG
	@IDNV INT,@LOAIHOPDONG NVARCHAR(MAX), @LOAILUONG INT, @NGAYKY DATE
	AS
	BEGIN
		INSERT INTO HOPDONGLAODONG(NHANVIENID, LOAIHOPDONG, LUONGID, NGAYKY) VALUES(@IDNV, @LOAIHOPDONG, @LOAILUONG, @NGAYKY)
	END
	GO

	CREATE PROC UPDATEHOPDONGLAODONG
	@IDHOPDONG INT, @IDNV INT,@LOAIHOPDONG NVARCHAR(MAX), @LOAILUONG INT, @NGAYKY DATE
	AS
	BEGIN
		UPDATE HOPDONGLAODONG SET NHANVIENID = @IDNV, LOAIHOPDONG = @LOAIHOPDONG, LUONGID = @LOAILUONG, NGAYKY = @NGAYKY
		WHERE HOPDONGLAODONGID = @IDHOPDONG
	END
	GO

	CREATE PROC DELETEHOPDONGLAODONG
	@IDHOPDONG INT
	AS
	BEGIN
		DELETE HOPDONGLAODONG WHERE HOPDONGLAODONGID = @IDHOPDONG
	END
	GO

	CREATE PROC INSERTKHENTHUONGKYLUAT
	@IDNV INT,  @HINHTHUC INT, @NOIDUNG NVARCHAR(MAX), @THOIGIAN DATE
	AS
	BEGIN
		INSERT INTO KHENTHUONGKYLUAT(NHANVIENID, HINHTHUC, NOIDUNG, THOIGIAN) VALUES(@IDNV, @HINHTHUC, @NOIDUNG, @THOIGIAN)
	END
	GO

	CREATE PROC UPDATEKHENTHUONGKYLUAT
	@IDKTKL INT, @IDNV INT,  @HINHTHUC INT, @NOIDUNG NVARCHAR(MAX), @THOIGIAN DATE
	AS
	BEGIN
		UPDATE KHENTHUONGKYLUAT SET NHANVIENID = @IDNV, HINHTHUC = @HINHTHUC, NOIDUNG = @NOIDUNG, THOIGIAN = @THOIGIAN
		WHERE KHENTHUONGKYLUATID = @IDKTKL
	END
	GO

	CREATE PROC DELETEKHENTHUONGKYLUAT
	@IDKTKL INT
	AS
	BEGIN
		DELETE KHENTHUONGKYLUAT WHERE KHENTHUONGKYLUATID = @IDKTKL
	END
	GO

	CREATE PROC INSERTNHANVIEN
	@HOTEN NVARCHAR(MAX), @BIDANH NVARCHAR(MAX), @DIACHI NVARCHAR(MAX), @NGAYSINH DATE, @MASOTHUE NCHAR(15), @GIOITINH INT, @SOTKNGANHANG NCHAR(15), @SDT NCHAR(15), @EMAIL NVARCHAR(MAX), @CHUCVUID INT, @PHONGBANID INT
	AS
	BEGIN
		INSERT INTO NHANVIEN(HOTEN,BIDANH,DIACHI,NGAYSINH,MASOTHUE,GIOITINH,SOTKNGANHANG,SDT,EMAIL,CHUCVUID,PHONGBANID)
		VALUES(@HOTEN,@BIDANH,@DIACHI,@NGAYSINH,@MASOTHUE,@GIOITINH,@SOTKNGANHANG,@SDT,@EMAIL,@CHUCVUID,@PHONGBANID)
	END
	GO

	CREATE PROC UPDATENHANVIEN
	@NHANVIENID INT, @HOTEN NVARCHAR(MAX), @BIDANH NVARCHAR(MAX), @DIACHI NVARCHAR(MAX), @NGAYSINH DATE, @MASOTHUE NCHAR(15), @GIOITINH INT, @SOTKNGANHANG NCHAR(15), @SDT NCHAR(15), @EMAIL NVARCHAR(MAX), @CHUCVUID INT, @PHONGBANID INT
	AS
	BEGIN
		UPDATE NHANVIEN SET HOTEN = @HOTEN, BIDANH = @BIDANH, DIACHI = @DIACHI,
							NGAYSINH = @NGAYSINH, MASOTHUE = @MASOTHUE, GIOITINH = @GIOITINH,
							SOTKNGANHANG = @SOTKNGANHANG, SDT = @SDT, EMAIL = @EMAIL,
							CHUCVUID = @CHUCVUID, PHONGBANID = @PHONGBANID
		WHERE NHANVIENID = @NHANVIENID
	END
	GO

	CREATE PROC DELETENHANVIEN
	@NHANVIENID INT
	AS
	BEGIN
		DELETE NHANVIEN WHERE NHANVIENID = @NHANVIENID
	END
	GO

	CREATE PROC INSERTQUATRINHCONGTAC
	@IDNV INT, @TGBATDAU DATE, @TGKETTHUC DATE, @NOIDUNG NVARCHAR(MAX) 
	AS
	BEGIN
		INSERT INTO QUATRINHCONGTAC(NHANVIENID, THOIGIANBATDAU, THOIGIANKETTHUC, NOIDUNGCONGTAC) VALUES(@IDNV, @TGBATDAU, @TGKETTHUC, @NOIDUNG)
	END
	GO

	CREATE PROC UPDATEQUATRINHCONGTAC
	@IDQTCT INT, @IDNV INT, @TGBATDAU DATE, @TGKETTHUC DATE, @NOIDUNG NVARCHAR(MAX) 
	AS
	BEGIN
		UPDATE QUATRINHCONGTAC SET NHANVIENID = @IDNV, THOIGIANBATDAU = @TGBATDAU, THOIGIANKETTHUC = @TGKETTHUC, NOIDUNGCONGTAC = @NOIDUNG
		WHERE QUATRINHCONGTACID = @IDQTCT
	END
	GO

	CREATE PROC DELETEQUATRINHCONGTAC
	@IDQTCT INT
	AS
	BEGIN
		DELETE QUATRINHCONGTAC WHERE QUATRINHCONGTACID = @IDQTCT
	END
	GO

	CREATE PROC INSERTQUATRINHHOCTAP
	@IDNV INT, @TGBATDAU DATE, @TGKETTHUC DATE, @NOIDUNG NVARCHAR(MAX) 
	AS
	BEGIN
		INSERT INTO QUATRINHHOCTAP(NHANVIENID, THOIGIANBATDAU, THOIGIANKETTHUC, NOIDUNGHOCTAP) VALUES(@IDNV, @TGBATDAU, @TGKETTHUC, @NOIDUNG)
	END
	GO

	CREATE PROC UPDATEQUATRINHHOCTAP
	@IDQTHT INT, @IDNV INT, @TGBATDAU DATE, @TGKETTHUC DATE, @NOIDUNG NVARCHAR(MAX) 
	AS
	BEGIN
		UPDATE QUATRINHHOCTAP SET NHANVIENID = @IDNV, THOIGIANBATDAU = @TGBATDAU, THOIGIANKETTHUC = @TGKETTHUC, NOIDUNGHOCTAP = @NOIDUNG
		WHERE QUATRINHOCTAPID = @IDQTHT
	END
	GO

	CREATE PROC DELETEQUATRINHHOCTAP
	@IDQTHT INT
	AS
	BEGIN
		DELETE QUATRINHHOCTAP WHERE QUATRINHOCTAPID = @IDQTHT
	END
	GO

	CREATE PROC INSERTBANGCAP
	@IDNV INT, @TRINHDOHOCVAN NVARCHAR(MAX), @THOIGIAN DATE, @CHITIET NVARCHAR(MAX) 
	AS
	BEGIN
		INSERT INTO BANGCAP(NHANVIENID, TRINHDOHOCVAN, THOIGIAN, CHITIETBANGCAP ) VALUES(@IDNV, @TRINHDOHOCVAN, @THOIGIAN, @CHITIET)
	END
	GO

	CREATE PROC UPDATEBANGCAP
	@IDBANGCAP INT, @IDNV INT, @TRINHDOHOCVAN NVARCHAR(MAX), @THOIGIAN DATE, @CHITIET NVARCHAR(MAX) 
	AS
	BEGIN
		UPDATE BANGCAP SET NHANVIENID = @IDNV, TRINHDOHOCVAN = @TRINHDOHOCVAN, THOIGIAN = @THOIGIAN, CHITIETBANGCAP = @CHITIET
		WHERE BANGCAPID = @IDBANGCAP
	END
	GO

	CREATE PROC DELETEBANGCAP
	@IDBANGCAP INT
	AS
	BEGIN
		DELETE BANGCAP WHERE BANGCAPID = @IDBANGCAP
	END
	GO

	CREATE PROC INSERTTHANNHAN
	@IDNHANVIEN INT, @HOTEN NVARCHAR(MAX), @GIOITINH INT, @CHUCVUID INT
	AS
	BEGIN
		INSERT INTO THANNHAN(NHANVIENID, HOTEN, GIOITINH, CHUCVUID ) VALUES(@IDNHANVIEN, @HOTEN, @GIOITINH, @CHUCVUID)
	END
	GO

	CREATE PROC UPDATETHANNHAN
	@IDTHANHNHAN INT, @IDNHANVIEN INT, @HOTEN NVARCHAR(MAX), @GIOITINH INT, @CHUCVUID INT
	AS
	BEGIN
		UPDATE THANNHAN SET NHANVIENID = @IDNHANVIEN, HOTEN = @HOTEN, GIOITINH = @GIOITINH, CHUCVUID = @CHUCVUID
		WHERE THANNHANID = @IDTHANHNHAN
	END
	GO

	CREATE PROC DELETETHANNHAN
	@IDTHANNHAN INT
	AS
	BEGIN
		DELETE THANNHAN WHERE THANNHANID = @IDTHANNHAN
	END
	GO

	CREATE PROC INSERTTAISAN
	@IDNV INT, @TEN NVARCHAR(MAX), @GHICHU NVARCHAR(MAX)
	AS
	BEGIN
		INSERT INTO TAISAN(NHANVIENID, TEN, GHICHU ) VALUES(@IDNV,@TEN, @GHICHU)
	END
	GO

	CREATE PROC UPDATETAISAN
	@IDTAISAN INT, @IDNV INT, @TEN NVARCHAR(MAX), @GHICHU NVARCHAR(MAX)
	AS
	BEGIN
		UPDATE TAISAN SET NHANVIENID = @IDNV, TEN = @TEN, GHICHU = @GHICHU
		WHERE TAISANID = @IDTAISAN
	END
	GO

	CREATE PROC DELETETAISAN
	@IDTAISAN INT
	AS
	BEGIN
		DELETE TAISAN WHERE TAISANID = @IDTAISAN
	END
	GO

	CREATE PROC INSERTTHONGTINDANG
	@IDNV INT, @NGAYKETNAP DATE, @NGAYROIKHOI DATE
	AS
	BEGIN
		INSERT INTO THONGTINDANG(NHANVIENID, NGAYKETNAP, NGAYRAKHOIDANG ) VALUES(@IDNV,@NGAYKETNAP, @NGAYROIKHOI)
	END
	GO

	CREATE PROC UPDATETHONGTINDANG
	@THONGTINDANGID INT, @IDNV INT, @NGAYKETNAP DATE, @NGAYROIKHOI DATE
	AS
	BEGIN
		UPDATE THONGTINDANG SET NHANVIENID = @IDNV, NGAYKETNAP = @NGAYKETNAP, NGAYRAKHOIDANG = @NGAYROIKHOI
		WHERE THONGTINDANGID = @THONGTINDANGID
	END
	GO

	CREATE PROC DELETETHONGTINDANG
	@THONGTINDANGID INT
	AS
	BEGIN
		DELETE THONGTINDANG WHERE THONGTINDANGID = @THONGTINDANGID
	END
	GO

	CREATE PROC INSERTCHAMCONG
	@NHANVIENID INT, @NGAY DATE, @LOAI INT
	AS
	BEGIN
		INSERT INTO CHAMCONG(NHANVIENID, NGAY, LOAI) VALUES(@NHANVIENID, @NGAY, @LOAI)
	END
	GO

	CREATE PROC UPDATECHAMCONG
	@CHAMCONGID INT, @NHANVIENID INT, @NGAY DATE, @LOAI INT
	AS
	BEGIN
		UPDATE CHAMCONG SET NHANVIENID = @NHANVIENID, NGAY = @NGAY, LOAI = @LOAI
		WHERE CHAMCONGID = @CHAMCONGID
	END
	GO

	CREATE PROC DELETECHAMCONG
	@CHAMCONGID INT
	AS
	BEGIN
		DELETE CHAMCONG WHERE CHAMCONGID = @CHAMCONGID
	END
	GO

	CREATE PROC THONGKE_NGHIHUU
	@NGAY DATE
	AS
	BEGIN
		SELECT N.HOTEN, N.GIOITINH, N.CHUCVUID, N.PHONGBANID, C.TEN AS TENCV, P.TEN AS TENPB, G.TEN AS TENGIOITINH 
		FROM NHANVIEN N, GIOITINH G, CHUCVU C, PHONGBAN P
		WHERE YEAR(@NGAY) - YEAR(N.NGAYSINH) >= 55  AND N.CHUCVUID = C.CHUCVUID AND N.GIOITINH = G.GIOITINHID AND N.PHONGBANID = P.PHONGBANID
	END
	GO

	CREATE PROC THONGKE_NVMOI
	@NGAY DATE
	AS
	BEGIN
		SELECT N.HOTEN, N.GIOITINH, N.CHUCVUID, N.PHONGBANID, C.TEN AS TENCV, P.TEN AS TENPB, G.TEN AS TENGIOITINH 
		FROM NHANVIEN N, GIOITINH G, CHUCVU C, PHONGBAN P
		WHERE YEAR(@NGAY) - YEAR(N.NGAYSINH) < 55  AND N.CHUCVUID = C.CHUCVUID AND N.GIOITINH = G.GIOITINHID AND N.PHONGBANID = P.PHONGBANID
	END
	GO
GO
CREATE PROC USP_LOGIN 
@username VARCHAR(50) , @password VARCHAR(50)
AS
BEGIN
	SELECT * FROM ACCOUNT WHERE USERNAME = @username AND PASSWORD = @password
END
GO
--- END ---