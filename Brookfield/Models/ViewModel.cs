using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Brookfield.Models
{
    public class ViewModel
    {
        public const string jsonData = "[{\"OrderID\":1,\"EmployeeID\":100,\"FirstName\":'Gina',\"LastName\":'Gable'}," +
                                       "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":2,\"EmployeeID\":200,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":3,\"EmployeeID\":300,\"FirstName\":'Frank',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":4,\"EmployeeID\":400,\"FirstName\":'Jack',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":5,\"EmployeeID\":500,\"FirstName\":'Katie',\"LastName\":'Gable'}," +
                                      "{\"OrderID\":6,\"EmployeeID\":600,\"FirstName\":'Mendoza',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":7,\"EmployeeID\":700,\"FirstName\":'Rooney',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":8,\"EmployeeID\":800,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":9,\"EmployeeID\":900,\"FirstName\":'Adams',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":10,\"EmployeeID\":1000,\"FirstName\":'Danielle',\"LastName\":'Rooney'}," +
                                      "{\"OrderID\":11,\"EmployeeID\":1100,\"FirstName\":'Adams',\"LastName\":'Mendoza'}," +
                                      "{\"OrderID\":12,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":13,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":14,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'}," +
                                      "{\"OrderID\":15,\"EmployeeID\":1200,\"FirstName\":'Danielle',\"LastName\":'Adams'},]";

        public ObservableCollection<DynamicModel> DynamicCollection { get; set; }
        public List<Dictionary<string, object>> DynamicJsonCollection { get; set; }

        public ViewModel()
        {
            DynamicJsonCollection = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonData);
            DynamicCollection = PopulateData();
        }

        private ObservableCollection<DynamicModel> PopulateData()
        {
            var data = new ObservableCollection<DynamicModel>();
            foreach (var item in DynamicJsonCollection)
            {
                var obj = new DynamicModel() { Values = item };
                data.Add(obj);
            }
            return data;
        }

        public void RefreshGroup(string key)
        {
            foreach (var dynamicItem in this.DynamicCollection)
            {
                dynamicItem.RefreshGroupProperty(key);
            }
        }
    }
}
