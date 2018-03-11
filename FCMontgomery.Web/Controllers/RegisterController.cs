using FCMontgomery.Business;
using FCMontgomery.Business.Exceptions;
using FCMontgomery.Dto;
using System;
using System.Net.Mail;
using System.Web.Mvc;

namespace FCMontgomery.Web.Controllers
{
    public class RegisterController : Controller
    {
        private RegisterBusiness registerBusiness;

        public RegisterController()
        {
            registerBusiness = new RegisterBusiness();
        }

        public ActionResult Index(RegisterDto registerDto)
        {
            return View(registerDto);
        }

        [HttpPost]
        public JsonResult Send(RegisterDto registerDto)
        {
            try
            {
                registerBusiness.ValidRegister(registerDto);

                var smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("contato@chicodocolchao.com.br", "c0nt4t0");
                smtp.Port = 587;
                smtp.Host = "smtpi.chicodocolchao.com.br";
                var mail = new MailMessage();
                mail.From = new MailAddress("contato@chicodocolchao.com.br");
                mail.To.Add("mateusc.eng@gmail.com"); //brunomr@fcmontgomery.com
                mail.Subject = "Register-Website";
                mail.Body = "This email was sent by : \n"
                            + "Name: " + registerDto.Name + "\n"
                            + "E-mail: " + registerDto.Email + "\n"
                            + "Category: " + registerDto.Category + "\n"
                            + "Phone: " + registerDto.Phone + "\n"
                            + "Address: " + registerDto.Address + "\n"
                            + "City: " + registerDto.City + "\n"
                            + "BirthDay: " + registerDto.BirthDay + "\n"
                            + "Gender: " + registerDto.Gender + "\n"
                            + "Parent's Name: " + registerDto.ParentName + "\n"
                            + "Parent's Phone: " + registerDto.ParentPhone + "\n"
                            + "Parent's E-mail: " + registerDto.ParentEmail + "\n"
                            + "Position: " + registerDto.Position + "\n"
                            + "Club Experience: " + registerDto.ClubExperience + "\n"
                            + "Year Experience: " + registerDto.YearExperience;

                smtp.Send(mail);

                return Json(new { Sucesso = true, Mensagem = "Message sent successfully" }, JsonRequestBehavior.AllowGet);
            }
            catch (BusinessException ex)
            {
                return Json(new { Sucesso = false, Mensagem = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Sucesso = false, Mensagem = "An error occured. Message wasn't send it. Try again", Erro = ex.ToString() }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}