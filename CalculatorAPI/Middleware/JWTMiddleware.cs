using CalculatorAPI.Service;

namespace CalculatorAPI.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IJWTValidationService jwtUtils)
        {

            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var IsValid = jwtUtils.ValidateJwtToken(token);
            context.Items.Add("IsValid", IsValid);

            await _next(context);
        }
    }
}
