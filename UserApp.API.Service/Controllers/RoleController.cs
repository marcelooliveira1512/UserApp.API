using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserApp.API.Service.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        /// <summary>
        /// Criar conta para um Perfil
        /// </summary>
        [Route("role/add")]
        [HttpPost]
        public IActionResult RoleAdd()
        {
            return Ok();
        }

        /// <summary>
        /// Editar a conta de um Perfil
        /// </summary>
        [Route("role/edit")]
        [HttpPut]
        public IActionResult RoleEdit()
        {
            return Ok();
        }

        /// <summary>
        /// Excluir a conta de um Perfil
        /// </summary>
        [Route("role/delete")]
        [HttpDelete]
        public IActionResult RoleDelete()
        {
            return Ok();
        }

        /// <summary>
        /// Consultar os dados da conta de um Perfil
        /// </summary>
        [Route("role/get")]
        [HttpGet]
        public IActionResult RoleGet()
        {
            return Ok();
        }


        /// <summary>
        /// Criar conta para um Módulo
        /// </summary>
        [Route("module/add")]
        [HttpPost]
        public IActionResult ModuleAdd()
        {
            return Ok();
        }

        /// <summary>
        /// Editar a conta de um Módulo
        /// </summary>
        [Route("module/edit")]
        [HttpPut]
        public IActionResult ModuleEdit()
        {
            return Ok();
        }

        /// <summary>
        /// Excluir a conta de um Módulo
        /// </summary>
        [Route("module/delete")]
        [HttpDelete]
        public IActionResult ModuleDelete()
        {
            return Ok();
        }

        /// <summary>
        /// Consultar os dados da conta de um Módulo
        /// </summary>
        [Route("module/get")]
        [HttpGet]
        public IActionResult ModuleGet()
        {
            return Ok();
        }


        /// <summary>
        /// Criar conta para um Submódulo
        /// </summary>
        [Route("child-module/add")]
        [HttpPost]
        public IActionResult ChildModuleAdd()
        {
            return Ok();
        }

        /// <summary>
        /// Editar a conta de um Submódulo
        /// </summary>
        [Route("child-module/edit")]
        [HttpPut]
        public IActionResult ChildModuleEdit()
        {
            return Ok();
        }

        /// <summary>
        /// Excluir a conta de um Submódulo
        /// </summary>
        [Route("child-module/delete")]
        [HttpDelete]
        public IActionResult ChildModuleDelete()
        {
            return Ok();
        }

        /// <summary>
        /// Consultar os dados da conta de um Submódulo
        /// </summary>
        [Route("child-module/get")]
        [HttpGet]
        public IActionResult ChildModuleGet()
        {
            return Ok();
        }

        /// <summary>
        /// Associar um Submódulo a um Módulo
        /// </summary>
        [Route("associate-child-module")]
        [HttpPost]
        public IActionResult AssociateChildModule()
        {
            return Ok();
        }

        /// <summary>
        /// Associar um Perfil a uma Regra de Permissão
        /// </summary>
        [Route("associate-role-permission")]
        [HttpPost]
        public IActionResult AssociateRolePermission()
        {
            return Ok();
        }
    }
}

