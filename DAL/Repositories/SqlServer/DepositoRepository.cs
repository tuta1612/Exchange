﻿using System;
using System.Collections.Generic;
using Domain;
using DAL.Contracts;
using DAL.Tools;
using System.Data.SqlClient;


namespace DAL.Repositories.SqlServer
{
    class DepositoRepository : IGenericRepository<Deposito>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Deposito] (Id, Cuenta, Monto, Moneda) VALUES (@Id, @Cuenta, @Monto, @Moneda)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Deposito] SET Cuenta = @Cuenta, Monto = @Monto, Moneda = @Moneda WHERE Id = @Id";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Deposito] WHERE Id = @Id";
        }

        private string SelectOneStatement
        {
            get => "SELECT Id, Id, Cuenta, Monto, Moneda FROM [dbo].[Deposito] WHERE Id = @Id";
        }

        private string SelectAllStatement
        {
            get => "SELECT Id, Id, Cuenta, Monto, Moneda FROM [dbo].[Deposito]";
        }
        #endregion


        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Deposito> GetAll()
        {
            throw new NotImplementedException();
        }

        public Deposito GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Deposito obj)
        {
            SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, new SqlParameter[] {
                        new SqlParameter("@Id", obj.guid),
                        new SqlParameter("@Cuenta", obj.cuenta.guid),
                        new SqlParameter("@Monto", obj.monto),
                        new SqlParameter("@Moneda", obj.moneda.ToString())});
        }

        public void Update(Deposito obj)
        {
            throw new NotImplementedException();
        }
    }
}
