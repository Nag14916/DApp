namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
            
        }

        [HttpGet("{id}")]
        public ActionResult<AppUSer> GetUsers(int id){
            return users=_context.Users.Find(id);
        }
    }
}