﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Domain;
using PE2_Project_Employee_Hours.Data;
using System.Data;

namespace PE2_Project_Employee_Hours.Logic
{
    public class BatchService
    {
        public async Task<ResultEnum> InsertBatch(Batch batch)
        {
            ResultEnum result = ResultEnum.Success;

            try
            {
                BatchDAO dao = new BatchDAO();
                await dao.InsertBatchASYNC(batch);
                

            }
            catch
            {

                result = ResultEnum.Fail;
            }
            return result;
        }

        public ResultEnum UpdateBatch(Batch batch)
        {
            ResultEnum result = ResultEnum.Success;

            try
            {
                BatchDAO dao = new BatchDAO();
                dao.UpdateBatch(batch);


            }
            catch
            {

                result = ResultEnum.Fail;
            }
            return result;
        }

        public async Task<ResultEnum> DeleteBatch(Batch batch)
        {
            ResultEnum result = ResultEnum.Success;
            
            try
            {
                BatchDAO dao = new BatchDAO();
                await dao.DeleteBatchASYNC(batch);


            }
            catch
            {

                result = ResultEnum.Fail;
            }
            return result;
        }

        public async Task<Result<DataTable>> GetAllBatchedDtASYNC()
        {
            //null result
            Result<DataTable> result = new Result<DataTable>();
            result.Status = ResultEnum.Success;
            try
            {
                BatchDAO dao = new BatchDAO();
                result.Data = await dao.GetAllBatchesASYNC();

            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public async Task<Result<DataTable>> FindBatchesByAny(string findString)
        {
            //null result
            Result<DataTable> result = new Result<DataTable>();
            result.Status = ResultEnum.Success;
            try
            {
                BatchDAO dao = new BatchDAO();
                result.Data =  await dao.FindBatchesDtASYNC(findString);

            }
            catch
            {
                result.Status = ResultEnum.Fail;
            }
            return result;
        }
    }
}
