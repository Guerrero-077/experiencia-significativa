using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Utilities.Pdf
{
    public static class EvaluationPdfGenerator
    {
        public static byte[] Generate(string TypeEvaluation, string comments)
        {
            // QuestPDF trabaja con licencias, así que declaramos esto (para liberar)
            QuestPDF.Settings.License = LicenseType.Community;

            var pdf = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(30);

                    page.Content().Column(col =>
                    {
                        col.Item().Text("REPORTE DE EVALUACIÓN").FontSize(20).Bold();
                        col.Item().Text($"Evaluador: {TypeEvaluation}");
                        col.Item().Text($"Comentarios: {comments}");
                        col.Item().Text($"Fecha: {DateTime.Now}");
                    });
                });
            });

            return pdf.GeneratePdf();  // Devuelve el PDF como byte[
        }
    }
}

