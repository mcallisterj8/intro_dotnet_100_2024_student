using System.Text.Json;
using CompanyInfo.Models;

const string jsonFilePath = "./company_info.json";
string json = File.ReadAllText(jsonFilePath);

// Console.WriteLine(json);

var options = new JsonSerializerOptions() {PropertyNameCaseInsensitive = true};

//JSON.parse()
Company? companyA = JsonSerializer.Deserialize<Company>(json, options);

Employee employeeA = companyA.Employees[0];

Console.WriteLine($"{employeeA.FullName} Position: {employeeA?.Position?.Description}");
Console.WriteLine($"{companyA.Employees[0].FullName} Position: {companyA.Employees[0]?.Position?.Description}");

Console.WriteLine("===================================================");

employeeA.Position.Description = "CIO";

Console.WriteLine($"{employeeA.FullName} Position: {employeeA?.Position?.Description}");
Console.WriteLine($"{companyA.Employees[0].FullName} Position: {companyA.Employees[0]?.Position?.Description}");

var moreOptions = new JsonSerializerOptions {WriteIndented = true};

string jsonString = JsonSerializer.Serialize(companyA, moreOptions);
File.WriteAllText(jsonFilePath, jsonString);




// const string writeDir = "employees_directory";

// Directory.CreateDirectory(writeDir);
// // move into directory
// Directory.SetCurrentDirectory(writeDir);

// foreach(Employee person in companyA.Employees) {
//     string fileName = $"{person.Id}.txt";

//     string contents = @$"
//     ID: {person.Id}
//     Full Name: {person.FullName}
//     Annual Salary: {person.AnnualSalary}
//     Position ID: {person.Position.Id}
//     Position Description: {person.Position.Description}
    
//     Benefits:
//     ---------
//     ";
//     foreach(Benefit singleBenefit in person.Benefits) {
//         contents += @$"
//         Description: {singleBenefit.Description}
//         Additional: {singleBenefit.Additional}
//         ";
//     }

//     File.WriteAllText(fileName, contents);
// }

// Directory.SetCurrentDirectory("..");
