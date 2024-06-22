using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Mithril.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Name", "EffortPointsPerMinute", "Image", "Description", "DifficultyLevel", "MuscleGroup", "ApproxTimeToDoOneRep" },
                values: new object[,]
                {
                    { 1, "Pompka", 8.5, "pompka.jpg", "Podstawowe ćwiczenie wzmacniające górną część ciała", "Początkujący", "Klatka piersiowa", 2.0 },
                    { 2, "Przysiad", 7.5, "przysiad.jpg", "Podstawowe ćwiczenie wzmacniające dolną część ciała", "Początkujący", "Nogi", 3.0 },
                    { 3, "Podciąganie", 9.0, "podciaganie.jpg", "Wymagające ćwiczenie wzmacniające górną część ciała", "Zaawansowany", "Plecy", 4.0 },
                    { 4, "Deska", 6.0, "deska.jpg", "Ćwiczenie wzmacniające mięśnie brzucha", "Średniozaawansowany", "Brzuch", 5.0 },
                    { 5, "Wykrok", 7.0, "wykrok.jpg", "Ćwiczenie wzmacniające dolną część ciała", "Początkujący", "Nogi", 3.0 },
                    { 6, "Martwy ciąg", 10.0, "martwyciag.jpg", "Ćwiczenie wzmacniające całe ciało", "Zaawansowany", "Plecy", 4.0 },
                    { 7, "Wyciskanie na ławce", 8.5, "wyciskanie.jpg", "Ćwiczenie wzmacniające górną część ciała", "Średniozaawansowany", "Klatka piersiowa", 3.0 },
                    { 8, "Uginanie bicepsów", 6.5, "uginaniebicepsow.jpg", "Ćwiczenie wzmacniające ramiona", "Początkujący", "Ramiona", 2.0 },
                    { 9, "Dipy tricepsowe", 7.5, "dipytricepsowe.jpg", "Ćwiczenie wzmacniające górną część ciała", "Średniozaawansowany", "Ramiona", 3.0 },
                    { 10, "Burpee", 9.5, "burpee.jpg", "Ćwiczenie wzmacniające całe ciało, składające się z przysiadu, skoku i pompki", "Zaawansowany", "Całe ciało", 4.0 },
                    { 11, "Wspinaczka górska", 8.0, "wspinaczkagorska.jpg", "Ćwiczenie cardio i wzmacniające", "Średniozaawansowany", "Brzuch", 2.5 },
                    { 12, "Wysokie kolana", 7.0, "wysokiekolana.jpg", "Ćwiczenie cardio polegające na biegu w miejscu", "Początkujący", "Nogi", 1.5 },
                    { 13, "Pajacyk", 7.0, "pajacyk.jpg", "Ćwiczenie cardio angażujące całe ciało", "Początkujący", "Całe ciało", 2.0 },
                    { 14, "Rosyjski twist", 6.5, "rosyjski.jpg", "Ćwiczenie wzmacniające skośne mięśnie brzucha", "Średniozaawansowany", "Brzuch", 3.0 },
                    { 15, "Unoszenie nóg", 6.0, "unoszenienog.jpg", "Ćwiczenie angażujące dolne mięśnie brzucha", "Początkujący", "Brzuch", 3.5 }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }
            );
        }
    }
}
