using System.ComponentModel.DataAnnotations;

namespace CRUDMVCProj.PL.ViewModels.Auth
{
	public class ForgetPasswordViewModel
	{
		[Required(ErrorMessage = "Email is Required !")]
		[EmailAddress(ErrorMessage = "Invalid Email")]
		public string Email { get; set; }
	}
}
