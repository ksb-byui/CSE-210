using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume myResume = new Resume("Allison Rose");

        myResume.AddJob(job1);
        myResume.AddJob(job2);

        myResume.DisplayResume();
    }
}
