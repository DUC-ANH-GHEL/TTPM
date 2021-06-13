using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace functionrequire.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "VUI LÒNG NHẬP ĐẦY ĐỦ HỌ TÊN CỦA BẠN")]
        public string FullName { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "VUI LÒNG NHẬP VÀO MÃ ID CỦA BẠN")]
        [RegularExpression(@"^[B][0-9]{4}$", ErrorMessage = "VUI LÒNG NHẬP ĐÚNG ĐỊNH DẠNG ")]
        public string Pass { get; set; }
        public bool Status { get; set; }
        public DateTime Date_Create { get; set; }
    }
}