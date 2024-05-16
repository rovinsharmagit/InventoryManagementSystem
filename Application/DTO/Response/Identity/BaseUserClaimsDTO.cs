namespace Application.DTO.Response.Identity
{
    public class BaseUserClaimsDTO
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public bool ManageUser  { get; set; }
        public bool Read {  get; set; } 
        public bool Update { get; set; }    
        public bool Delete { get; set; }    
        public bool Create { get; set; }
    }
}
