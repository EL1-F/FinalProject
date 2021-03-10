using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccsess
{
    //generic constraint >> generic kısıtlama
    public interface IEntityRepository<T> where T:class , IEntity ,new() //referans tip class olabilir demektir ve 
        //bu class IEntity olabilir
        //new'lenebilir olmalı (yani IEntity yi devredışı bırakıyoruz)
    { 
        //getall da parantez içindeki yazım linq kullanmamıza yarar.
        List<T> GetAll(Expression<Func<T,bool>> filter =null);

        //detaya gitmek için kullanılır.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
