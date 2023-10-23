namespace BMICalculatorTaskWpfApp.Validators
{
    internal interface IValidate
    {
        bool Validation(out string message);
    }
}