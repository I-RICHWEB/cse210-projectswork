using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._company = "Microsoft";
        job._jobTitle = "Software Engineer";
        job._startYear = 2014;
        job._endYear = 2020;

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Manager";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Resume resume1 = new Resume();
        resume1.name = "Uyiosa Richmond Izekor";
        resume1.joblist.Add(job);
        resume1.joblist.Add(job1);

        resume1.DisplayResume();
    }
}