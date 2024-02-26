using System.Text.Json;
using CompanyInfo.Models;

const string jsonFilePath = "./company_info.json";
string json = File.ReadAllText(jsonFilePath);

var options = new JsonSerializerOptions() {PropertyNameCaseInsensitive = true};

//JSON.parse()
Company? companyA = JsonSerializer.Deserialize<Company>(json, options);

const string writeDir = "employees";
EmployeeWriter writer = new EmployeeWriter(writeDir);

EmployeeOptions empOptions = new EmployeeOptions() {IncludePosition = true, IncludeBenefits = true};

Employee singleEmployee = companyA.Employees[0];

// writer.Write(companyA.Employees[0], empOptions);
writer.Write(singleEmployee, empOptions);