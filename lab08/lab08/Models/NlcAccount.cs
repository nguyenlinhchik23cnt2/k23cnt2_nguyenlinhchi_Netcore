﻿using System.ComponentModel.DataAnnotations;

namespace lab08.Models
{
    public class NlcAccount
    {
        [Key]
        public int NlcId { get; set; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Họ không được để trống")]
        [MinLength(6, ErrorMessage = "Họ tên ít nhất là 6 ký tự")]
        [MaxLength(20, ErrorMessage = "Họ tên tối đa 20 ký tự")]
        public string NlcFullName { get; set; }

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng")]
        
        public string NlcEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(?[0-9]{3}\)?)[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "Số điện thoại không đúng định dạng")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string NlcPhone { get; set; }

        [Display(Name = "Địa chỉ thường trú")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "Địa chỉ không vượt quá 35 ký tự")]
        public string NlcAddress { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string NlcAvatar { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime NlcBirthday { get; set; }

        [Display(Name = "Giới tính")]
        public string NlcGender { get; set; }

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string NlcPassword { get; set; }

        [Display(Name = "Link Facebook cá nhân")]
        [Required(ErrorMessage = "Link Facebook không được để trống")]
        [Url(ErrorMessage = "Url phải đúng định dạng bao gồm http hoặc https, tên miền VD: https://facebook.com/ten")]
        public string NlcFacebook { get; set; }
    }
}
