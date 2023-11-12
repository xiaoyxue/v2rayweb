using Microsoft.AspNetCore.Mvc;

namespace V2RayWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class V2RayNodesController : ControllerBase
    {
        private readonly ILogger<V2RayNodesController> _logger;
        public V2RayNodesController(ILogger<V2RayNodesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetV2RayNodes")]
        public string Get()
        {
            return "vmess://eyJhZGQiOiJqcGVhc3QuamFwYW5lYXN0LmNsb3VkYXBwLmF6dXJlLmNvbSIsImFpZCI6IjY0IiwiYWxwbiI6IiIsImZwIjoiIiwiaG9zdCI6IiIsImlkIjoiMjNkYWQ4MmItY2E0NC00ZWRlLWJiOWEtYWE1MWIwMWE5ZTJiIiwibmV0IjoidGNwIiwicGF0aCI6IiIsInBvcnQiOiIyODMwMiIsInBzIjoiSmFwYW5FYXN0QWdlbnQiLCJzY3kiOiJub25lIiwic25pIjoiIiwidGxzIjoiIiwidHlwZSI6Im5vbmUiLCJ2IjoiMiJ9\r\n" +
                   "vmess://eyJhZGQiOiJrb2VyYWMua29yZWFjZW50cmFsLmNsb3VkYXBwLmF6dXJlLmNvbSIsImFpZCI6IjY0IiwiYWxwbiI6IiIsImZwIjoiIiwiaG9zdCI6IiIsImlkIjoiOTY1ZWNhZDYtZjFlMy00ODgzLThhMDktNGFhZDY4ZWM2Y2E5IiwibmV0IjoidGNwIiwicGF0aCI6IiIsInBvcnQiOiIyODMwMiIsInBzIjoiS29lcmFDZW50cmFsIiwic2N5Ijoibm9uZSIsInNuaSI6IiIsInRscyI6IiIsInR5cGUiOiJub25lIiwidiI6IjIifQ==\r\n" +
                   "vmess://eyJhZGQiOiJub3J0aHVzLm5vcnRoY2VudHJhbHVzLmNsb3VkYXBwLmF6dXJlLmNvbSIsImFpZCI6IjY0IiwiYWxwbiI6IiIsImZwIjoiIiwiaG9zdCI6IiIsImlkIjoiMjFlYmVmNGYtMGNjNC00ZTIyLTg0YjMtNjdjZDJmNTA5NTk2IiwibmV0IjoidGNwIiwicGF0aCI6IiIsInBvcnQiOiIyODMwMiIsInBzIjoiTm9ydGhVUyIsInNjeSI6Im5vbmUiLCJzbmkiOiIiLCJ0bHMiOiIiLCJ0eXBlIjoibm9uZSIsInYiOiIyIn0=\r\n" +
                   "vmess://eyJhZGQiOiJzb3V0aGVhLnNvdXRoZWFzdGFzaWEuY2xvdWRhcHAuYXp1cmUuY29tIiwiYWlkIjoiNjQiLCJhbHBuIjoiIiwiZnAiOiIiLCJob3N0IjoiIiwiaWQiOiI1MTYxNWRjNy1iNWU3LTQzYjAtOTU0Ny1kYWMzOWM5NzU0ZjYiLCJuZXQiOiJ0Y3AiLCJwYXRoIjoiIiwicG9ydCI6IjI4MzAyIiwicHMiOiJTb3V0aGVhc3RBc2lhQWdlbnQiLCJzY3kiOiJub25lIiwic25pIjoiIiwidGxzIjoiIiwidHlwZSI6Im5vbmUiLCJ2IjoiMiJ9\r\n" +
                   "vmess://eyJhZGQiOiJzY3UwLnNvdXRoY2VudHJhbHVzLmNsb3VkYXBwLmF6dXJlLmNvbSIsImFpZCI6IjY0IiwiYWxwbiI6IiIsImZwIjoiIiwiaG9zdCI6IiIsImlkIjoiZTcyMDkyYTgtNmQ1My00MjExLWE3NmQtYWQ5YzVhNWVjMzQyIiwibmV0IjoidGNwIiwicGF0aCI6IiIsInBvcnQiOiIyODMwMiIsInBzIjoiU291dGggQ2VudHJhbCBVcyIsInNjeSI6Im5vbmUiLCJzbmkiOiIiLCJ0bHMiOiIiLCJ0eXBlIjoibm9uZSIsInYiOiIyIn0=\r\n" +
                   "vmess://eyJhZGQiOiJhdXN0cmEuYXVzdHJhbGlhZWFzdC5jbG91ZGFwcC5henVyZS5jb20iLCJhaWQiOiI2NCIsImFscG4iOiIiLCJmcCI6IiIsImhvc3QiOiIiLCJpZCI6Ijg4ODhjNDk1LTc3YzctNDU4ZS1iZTEyLTViMmZhYmVmMzc2NyIsIm5ldCI6InRjcCIsInBhdGgiOiIiLCJwb3J0IjoiMjgzMDIiLCJwcyI6IkF1c3RyYWxpYSIsInNjeSI6Im5vbmUiLCJzbmkiOiIiLCJ0bHMiOiIiLCJ0eXBlIjoibm9uZSIsInYiOiIyIn0=\r\n";
        }
    }
}
