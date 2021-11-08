using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Ultils
{
    public class StringManagement
    {
        public static string GameTitle = "Ô Ăn Quan";
        public static string MessTitle = "Thông báo";
        public static string UsernamePlaceHolder = "Tên đăng nhập...";
        public static string PasswordPlaceHolder = "Mật khẩu...";
        public static string RequiredPasswordPlaceHolder = "Nhập lại mật khẩu...";
        public static string NamePlaceHolder = "Tên nhân vật...";
        public static string SuccessfulRegist_Mess = "Đăng kí thành công!";
        public static string SuccessfulLogIn_Mess = "Đăng nhập thành công!";
        public static string FailLogIn_Mess = "Tên đăng nhập hoặc mật khẩu không hợp lệ";
        public static string Alert_ExistUsername = "Tên đăng nhập đã tồn tại";
        public static string Alert_ExistName = "Tên nhân vật đã tồn tại";
        public static string Alert_UserNameLength = "Tên đăng nhập phải có độ dài từ 8 - 20";
        public static string Alert_PasswordLength = "Mật khẩu phải có độ dài từ 8 - 20";
        public static string Alert_NameLength = "Tên nhân vật phải có độ dài từ 8 - 20"; 
        public static string Alert_NotMatchPassword = "Mật khẩu không trùng khớp";
        public static string Alert_EmtyData = "Thông tin không được để trống";
        public static string Leave_Mess = "Bạn có thực sự muốn thoát?";
        public static string[] List_CharacterName =
            { "Quỷnh", "Hợi","Quỷnh", "Ngọ", "Tý", "Sửu", "Dần", "Mẹo", "Băng Băng", "Hàn Hàn", "Vũ Vũ", "Lôi Lôi"};
        public static string WinTitle = "Thắng";
        public static string LoseTitle = "Thua";
        public static string DrawTitle = "Hòa";
        public static string WinScore = "+10đ";
        public static string LoseScore = "-10đ";
        public static string DrawScore = "+0đ";
        public static string BackMainGame = "Nếu bạn muốn trở về thì bạn sẽ bị tính là thua và bị trừ 10 điểm";
        public static string PlayerTurn = "Đến lượt bạn";
        public static string BotTurn = "Đến lượt máy";

        public class KeyDatas
        {
            public static string AccountBLL_Key = "AccountBLL";
            public static string AccountDTO_Key = "AccountDTO";
            public static string CharacterDTO_Key = "CharacterDTO";
            public static string CharacterBLL_Key = "CharacterBLL";
            public static string PlayerAvatar_Key = "PlayerAvatar";
            public static string BotAvatar_Key = "BotAvatar";

        }
    }
}
