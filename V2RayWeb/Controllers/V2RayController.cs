using Microsoft.AspNetCore.Mvc;

namespace V2RayWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class V2RayController : ControllerBase
    {
        private readonly ILogger<V2RayController> _logger;
        public V2RayController(ILogger<V2RayController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetV2Ray")]
        public string Get()
        {
            return "vmess://eyJhZGQiOiJ4eHlqYXBhbi5qYXBhbmVhc3QuY2xvdWRhcHAuYXp1cmUuY29tIiwiYWlkIjoiNjQiLCJhbHBuIjoiIiwiaG9zdCI6IiIsImlkIjoiMjNkYWQ4MmItY2E0NC00ZWRlLWJiOWEtYWE1MWIwMWE5ZTJiIiwibmV0IjoidGNwIiwicGF0aCI6IiIsInBvcnQiOiIyODMwMiIsInBzIjoiSmFwYW5FYXN0QWdlbnQiLCJzY3kiOiJub25lIiwic25pIjoiIiwidGxzIjoiIiwidHlwZSI6Im5vbmUiLCJ2IjoiMiJ9\r\n" +
                "vmess://eyJhZGQiOiJ4eHlzb3V0aGVhc3Rhc2lhLnNvdXRoZWFzdGFzaWEuY2xvdWRhcHAuYXp1cmUuY29tIiwiYWlkIjoiNjQiLCJhbHBuIjoiIiwiaG9zdCI6IiIsImlkIjoiNTE2MTVkYzctYjVlNy00M2IwLTk1NDctZGFjMzljOTc1NGY2IiwibmV0IjoidGNwIiwicGF0aCI6IiIsInBvcnQiOiIyODMwMiIsInBzIjoiU291dGhlYXN0QXNpYUFnZW50Iiwic2N5Ijoibm9uZSIsInNuaSI6IiIsInRscyI6IiIsInR5cGUiOiJub25lIiwidiI6IjIifQ==\r\n" +
                "vmess://eyJhZGQiOiJ4eHlrb2VyYWNlbnRyYWwua29yZWFjZW50cmFsLmNsb3VkYXBwLmF6dXJlLmNvbSIsImFpZCI6IjY0IiwiYWxwbiI6IiIsImhvc3QiOiIiLCJpZCI6Ijk2NWVjYWQ2LWYxZTMtNDg4My04YTA5LTRhYWQ2OGVjNmNhOSIsIm5ldCI6InRjcCIsInBhdGgiOiIiLCJwb3J0IjoiMjgzMDIiLCJwcyI6IktvZXJhQ2VudHJhbCIsInNjeSI6Im5vbmUiLCJzbmkiOiIiLCJ0bHMiOiIiLCJ0eXBlIjoibm9uZSIsInYiOiIyIn0=\r\n" +
                "vmess://eyJhZGQiOiJ4eHllYXN0YXNpYWlwNC5lYXN0YXNpYS5jbG91ZGFwcC5henVyZS5jb20iLCJhaWQiOiI2NCIsImFscG4iOiIiLCJob3N0IjoiIiwiaWQiOiI0MGQ4NmVlMi1kZGEyLTQ5YmYtODdlOS01NzI3MzdmM2M3MTUiLCJuZXQiOiJ0Y3AiLCJwYXRoIjoiIiwicG9ydCI6IjI4MzAyIiwicHMiOiJFYXN0QXNpYSIsInNjeSI6Im5vbmUiLCJzbmkiOiIiLCJ0bHMiOiIiLCJ0eXBlIjoibm9uZSIsInYiOiIyIn0=\r\n" +
                "vmess://eyJhZGQiOiJ4eHlub3J0aHVzaXB2NC5ub3J0aGNlbnRyYWx1cy5jbG91ZGFwcC5henVyZS5jb20iLCJhaWQiOiI2NCIsImFscG4iOiIiLCJob3N0IjoiIiwiaWQiOiIyMWViZWY0Zi0wY2M0LTRlMjItODRiMy02N2NkMmY1MDk1OTYiLCJuZXQiOiJ0Y3AiLCJwYXRoIjoiIiwicG9ydCI6IjI4MzAyIiwicHMiOiJOb3J0aFVTIiwic2N5Ijoibm9uZSIsInNuaSI6IiIsInRscyI6IiIsInR5cGUiOiJub25lIiwidiI6IjIifQ==";
        }
    }
}
