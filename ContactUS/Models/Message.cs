using System.ComponentModel.DataAnnotations;

namespace ContactUs.Models
{
    public class Message
    {
        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "{0}را وارد کنید ")]
        public string FullName { get; set; }

        [Display(Name = "موضوع پیام")]
        [Required(ErrorMessage = "{0} را وارد کنید")]
        public string Subject { get; set; }

        [Display(Name = "شماره تماس")]
        [Required(ErrorMessage ="{0} را وارد کنید")]
        [MaxLength(11,ErrorMessage ="novalid")]
        [MinLength(11,ErrorMessage ="novalid")]
        public string PhoneNumber { get; set; }

        [Display(Name = "متن پیام")]
        [Required(ErrorMessage = "{0} را وارد کنید")]
        public string MessageBody { get; set; }


        [Display(Name = "کد")]
        public int Code { get; set; }


        //[Compare("PhoneNumber",ErrorMessage ="kkkkdkdkdkkd")] ****************
        //[Range(10,29,ErrorMessage ="kkkkkkkkkkkk")] **************************
        //[EmailAddress(ErrorMessage ="jiejijijfjeiji")]*************************


    }
}
