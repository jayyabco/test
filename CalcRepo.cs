using Microsoft.AspNetCore.Builder.Extensions;

namespace WebApplication1
{
    public class CalcRepo
    {
        public CalcRepo()
        {
        }

        public async Task<ApiResultStatus> PostSync(int a, int b)
        {
            ApiResultStatus resp = new ApiResultStatus();
            try
            {
                await Task.Delay(10);

                throw new InvalidOperationException("Simulated exception for testing.");
            }
            catch (Exception ex)
            {
                resp.Error.Message = ex.Message;
                resp.Error.Status = "-500";
                resp.Error.StackTrace = ex.StackTrace!;
            }
            return resp;
        }
    }
}