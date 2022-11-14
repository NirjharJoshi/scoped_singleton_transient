﻿using Scoped_Singleton_Tansient_Web.Models;

namespace Scoped_Singleton_Tansient_Web.Repository.IRepository
{
    public interface ITransientStudentRepository
    {
        public List<Student> Students { get; set; }
        void AddStudent(Student student);
        int TotalStudent();
    }
}
