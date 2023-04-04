namespace CalculatorAPI.Service
{
    public interface IJWTValidationService
    {
        public string GenerateJwtToken(string username);
        public bool? ValidateJwtToken(string? token);
    }
}
