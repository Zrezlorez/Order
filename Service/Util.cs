using IronXL;
using Order.Database.Model;
using Order.Forms;

namespace Order.Service
{
    internal class Util
    {
        public static void ShowFormById(Form form, int id)
        {
            Form? newForm = null;

            if (id == 1) newForm = new ProductView();
            if (id == 2) newForm = new Report();
            if (id == 3) newForm = new Storages();
            if (id == 4) newForm = new AdminForm();
            if (newForm != null && form.GetType() != newForm.GetType())
            {
                form.Hide();
                newForm.Show();
            }

        }

        public static DateTime SetKindUtc(DateTime dateTime)
        {
            if (dateTime.Kind == DateTimeKind.Utc) { return dateTime; }
            return DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
        }

        public static string GenerateExcel(List<ChangeLog> changeLogs)
        {
            if (changeLogs.Count == 0) return "";
            WorkBook workBook = WorkBook.Create(ExcelFileFormat.XLSX);
            var workSheet = workBook.CreateWorkSheet("example_sheet");
            workSheet[$"A1"].Value = "Изменение";
            workSheet[$"B1"].Value = "Результат";
            workSheet[$"C1"].Value = "Дата";
            workSheet[$"D1"].Value = "Продукт";
            workSheet[$"E1"].Value = "Склад";
            for (int i = 1; i <= changeLogs.Count; i++)
            {
                var item = changeLogs[i - 1];
                workSheet[$"A{i}"].Value = item.Change;
                workSheet[$"B{i}"].Value = item.Result;
                workSheet[$"C{i}"].DateTimeValue = item.DateTime;
                workSheet[$"D{i}"].Value = item.Product.Name;
                workSheet[$"E{i}"].Value = item.Storage.Adress;
            }
            string name = $"report{DateTime.Now}.xlsx";
            workBook.SaveAs("test.xlsx");
            return name;
        }
    }
}
