using System.Net.Http.Headers;

namespace Services.External.SupabaseStorageService
{

    public class SupabaseStorageService
    {
        public async Task<string> UploadEvaluationPdfToSupabase(byte[] pdfBytes, int evaluationId)
        {
            string fecha = DateTime.UtcNow.ToString("dd-MM-yyyy");
            string fileName = $"Reporte-{evaluationId}-{fecha}.pdf";

            //  URL correcta 
            string supabaseUrl = "https://clzjdaburaytuimossnf.supabase.co";
            string supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImNsempkYWJ1cmF5dHVpbW9zc25mIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc2MTMyMjQ2MywiZXhwIjoyMDc2ODk4NDYzfQ.V2LsB80vdb3ymThtQBoyLrw6p6Nsx7w7n3DX39V2bPY";
            string bucket = "Experiencia-SignificativaPdf";

            using var client = new HttpClient();
            client.BaseAddress = new Uri(supabaseUrl);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
            client.DefaultRequestHeaders.Add("apikey", supabaseKey);

            // endpoint REST correcto
            string uploadUrl = $"/storage/v1/object/{bucket}/{fileName}";

            var content = new ByteArrayContent(pdfBytes);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");

            var response = await client.PostAsync(uploadUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error subiendo PDF a Supabase: {error}");
            }

            // URL pública 
            return $"{supabaseUrl}/storage/v1/object/public/{bucket}/{fileName}";
        }
    }
}

