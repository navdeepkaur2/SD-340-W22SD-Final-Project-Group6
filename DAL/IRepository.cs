﻿namespace SD_340_W22SD_Final_Project_Group6.DAL;

public interface IRepository<T>
{
    void Create(T entity);

    T Get(int id);

    T Get(Func<T, bool> predicate);

    ICollection<T> GetList(Func<T, bool> predicate);

    ICollection<T> GetAll();

    T Update(T entity);

    void Delete(T entity);

    void Save();
}