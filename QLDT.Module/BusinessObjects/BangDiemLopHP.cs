using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace QLDT.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class BangDiemLopHP : BaseObject
    {
        public BangDiemLopHP(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        private DangKyHoc _DangKyHocBDLHP;
        [Association("bdlhp-dkh")]
        [XafDisplayName("Học Viên")]
        public DangKyHoc DangKyHocBDLHP
        {
            get { return _DangKyHocBDLHP; }
            set { SetPropertyValue<DangKyHoc>(nameof(DangKyHocBDLHP), ref _DangKyHocBDLHP, value); }
        }

        private LopHocPhan _LopHP;
        [Association("bdlhp-lophp")]
        [XafDisplayName("Lớp Học Phần")]
        public LopHocPhan LopHP
        {
            get { return _LopHP; }
            set { SetPropertyValue<LopHocPhan>(nameof(LopHP), ref _LopHP, value); }
        }

        private double? _ChuyenCan;
        [XafDisplayName("Chuyên Cần")]
        public double? ChuyenCan
        {
            get { return _ChuyenCan; }
            set { SetPropertyValue<double?>(nameof(ChuyenCan), ref _ChuyenCan, value); }
        }


        private double? _LyThuyet;
        [XafDisplayName("Lý Thuyết")]
        public double? LyThuyet
        {
            get { return _LyThuyet; }
            set { SetPropertyValue<double?>(nameof(LyThuyet), ref _LyThuyet, value); }
        }


        private double? _ThucHanh;
        [XafDisplayName("Thực Hành")]
        public double? ThucHanh
        {
            get { return _ThucHanh; }
            set { SetPropertyValue<double?>(nameof(ThucHanh), ref _ThucHanh, value); }
        }


        private double? _GiuaKy;
        [XafDisplayName("Giữa Kỳ")]
        public double? GiuaKy
        {
            get { return _GiuaKy; }
            set { SetPropertyValue<double?>(nameof(GiuaKy), ref _GiuaKy, value); }
        }


        private double? _CuoiKy;
        [XafDisplayName("Cuối Kỳ")]
        public double? CuoiKy
        {
            get { return _CuoiKy; }
            set { SetPropertyValue<double?>(nameof(CuoiKy), ref _CuoiKy, value); }
        }


        private double? _TongKet;
        [XafDisplayName("Tổng Kết")]
        public double? TongKet
        {
            get { return _TongKet; }
            set { SetPropertyValue<double?>(nameof(TongKet), ref _TongKet, value); }
        }


        private bool _DuDieuKien;
        [XafDisplayName("Đủ Điều Kiện")]
        public bool DuDieuKien
        {
            get { return _DuDieuKien; }
            set { SetPropertyValue<bool>(nameof(DuDieuKien), ref _DuDieuKien, value); }
        }

        private string _GhiChu;
        [XafDisplayName("Ghi Chú")]
        public string GhiChu
        {
            get { return _GhiChu; }
            set { SetPropertyValue<string>(nameof(GhiChu), ref _GhiChu, value); }
        }


    }
}