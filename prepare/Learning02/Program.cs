using System;

class Program
{
    static void Main(string[] arg)
    {
        Job job1 = new Job();
        job1._career = "Student";
        job1._workPlace = "BYU-I";
        job1._startYear = 2026;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._career = "Doctor";
        job2._workPlace = "Hospital";
        job2._startYear = 2030;
        job2._endYear = 2070;

        job1.ShowJob();
        job2.ShowJob();

    }

}

