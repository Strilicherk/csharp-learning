namespace Company
{
    internal class Employee
    {
        public string name;
        public string role;
        public double salary;

        public void AdjustSalary(int adjustmentPercentage)
        {
            salary = salary + (salary / 100 * adjustmentPercentage);
        }

        public double CalculateHourlyRate()
        {
            return salary / 220;
        }

        public double CalculateOvertime(double nonRegularHours, int nightShiftPercentage)
        {
            return (((CalculateHourlyRate() + (CalculateHourlyRate() / 100 * nightShiftPercentage)) * nonRegularHours));
        }
    }
}
