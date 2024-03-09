using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserApp.API.Service.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Criar conta para um Novo Usuário
        /// </summary>
        [AllowAnonymous]
        [Route("add")]
        [HttpPost]
        public IActionResult Add()
        {
            return Ok();
        }

        /// <summary>
        /// Editar a conta de um Usuário
        /// </summary>
        [Route("edit")]
        [HttpPut] 
        public IActionResult Edit() 
        {
            return Ok();
        }

        /// <summary>
        /// Excluir a conta de um Usuário
        /// </summary>
        [Route("delete")]
        [HttpDelete]
        public IActionResult Delete() 
        {
            return Ok();
        }

        /// <summary>
        /// Consultar os dados da conta do Usuário
        /// </summary>
        [Route("get")]
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok();
        }

        /// <summary>
        /// Associar um Usuário a um Perfil
        /// </summary>
        [Route("associate-user-role")]
        [HttpPost]
        public IActionResult AssociateUserRole()
        {
            return Ok();
        }
    }


}
