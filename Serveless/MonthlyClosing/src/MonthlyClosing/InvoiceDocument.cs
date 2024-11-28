using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Reflection;

namespace MonthlyClosing;
internal class InvoiceDocument : IDocument
{
    public static Image LogoImage { get; } = Image.FromFile("logo.png");
    public Model Model { get; }
    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
    public InvoiceDocument(Model model) => Model = model;

    public void Compose(IDocumentContainer container)
    {
        container
        .Page(page =>
        {
            page.Margin(10);

            page.PageColor(Colors.Grey.Lighten2);

            page.Header().Element(ComposeHeader);
            page.Content().Element(ComposeContent);

            page.Footer().AlignCenter().Text(text =>
            {
                text.CurrentPageNumber();
                text.Span(" / ");
                text.TotalPages();
            });
        });
    }

    void ComposeHeader(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem().Column(column =>
            {
                column
                    .Item().Text($"{Model.ChurchName}")
                    .FontSize(20).SemiBold().FontColor(Colors.Black);

                column.Item().Text(text =>
                {
                    text.Span($"Competencia: {Model.Competence}").SemiBold();
                });
            });

            row.ConstantItem(175).Image(LogoImage);
        });
    }

    void ComposeContent(IContainer container)
    {
        container.PaddingVertical(40).Column(column =>
        {
            column.Spacing(20);

            column.Item().Element(ComposeTable);

            decimal totalPrice = 0;
            totalPrice = Model.FlowJsonFile.Last().CurrentBalance;

            column.Item().PaddingRight(5).AlignRight().Text($"Valor total final: {totalPrice:C}").SemiBold();

            //if (!string.IsNullOrWhiteSpace("titulo comentarios"))
            //    column.Item().PaddingTop(25).Element(ComposeComments);
        });
    }

    void ComposeTable(IContainer container)
    {
        var headerStyle = TextStyle.Default.SemiBold();

        container.Table(table =>
        {
            table.ColumnsDefinition(columns =>
            {
                columns.ConstantColumn(25);
                columns.RelativeColumn(10);
                columns.RelativeColumn(10);
                columns.RelativeColumn(10);
                columns.RelativeColumn(10);
                columns.RelativeColumn(10);
                columns.RelativeColumn(10);
                columns.RelativeColumn(10);
                columns.RelativeColumn(10);
            });

            table.Header(header =>
            {
                header.Cell().Text("#").FontSize(5);
                header.Cell().AlignRight().Text("Competencia").Style(headerStyle).FontSize(5);
                header.Cell().AlignRight().Text("Dia").Style(headerStyle).FontSize(5);
                header.Cell().AlignRight().Text("Valor anterior").Style(headerStyle).FontSize(5);
                header.Cell().AlignRight().Text("Valor atual").Style(headerStyle).FontSize(5);
                header.Cell().AlignRight().Text("Titulo").Style(headerStyle).FontSize(5);
                header.Cell().AlignRight().Text("Valor entrada").Style(headerStyle).FontSize(5);
                header.Cell().AlignRight().Text("Valor saida").Style(headerStyle).FontSize(5);
                header.Cell().AlignRight().Text("Total Operacao").Style(headerStyle).FontSize(5);

                header.Cell().ColumnSpan(9).PaddingTop(9).BorderBottom(1).BorderColor(Colors.Black);
            });

            var index = 0;
            foreach (var item in Model.FlowJsonFile)
            {
                index++;

                table.Cell().Element(CellStyle).Text($"{index}").FontSize(5);
                table.Cell().Element(CellStyle).AlignRight().Text(item.Competence).FontSize(5);
                table.Cell().Element(CellStyle).AlignRight().Text($"{Convert.ToDateTime(item.Day).ToString("yyyy-MM-dd")}").FontSize(5);
                table.Cell().Element(CellStyle).AlignRight().Text($"{item.PreviousBalance}").FontSize(5);
                table.Cell().Element(CellStyle).AlignRight().Text($"{item.CurrentBalance}").FontSize(5);
                table.Cell().Element(CellStyle).AlignRight().Text($"{item.Description}").FontSize(5);
                table.Cell().Element(CellStyle).AlignRight().Text($"{item.AmountInputOperation}").FontSize(5);
                table.Cell().Element(CellStyle).AlignRight().Text($"{item.AmountOutPutOperation}").FontSize(5);
                table.Cell().Element(CellStyle).AlignRight().Text($"{item.TotalOperation}").FontSize(5);

                static IContainer CellStyle(IContainer container) => container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(5);
            }
        });

    }

    void ComposeComments(IContainer container)
    {
        container.ShowEntire().Background(Colors.Grey.Lighten3).Padding(10).Column(column =>
        {
            column.Spacing(5);
            column.Item().Text("").FontSize(14).SemiBold();
            column.Item().Text("");
        });
    }
}
