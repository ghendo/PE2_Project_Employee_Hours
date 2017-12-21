using PE2_Project_Employee_Hours.Data;
using PE2_Project_Employee_Hours.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_Project_Employee_Hours.Logic
{

    public class RecyclerService
    {

        public async Task<ResultEnum> InsetRecyclerDtASYNC(Recycler recycler)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                RecyclerDAO dao = new RecyclerDAO();
                await dao.InsertRecyclerASYNC(recycler);
            }
            catch (Exception)
            {

                result = ResultEnum.Fail;
            }
            return result;
        }

        public async Task<Result<DataTable>> GetAllRecyclersDtASYNC()
        {
            Result<DataTable> result = new Result<DataTable>();
            try
            {
                RecyclerDAO dao = new RecyclerDAO();
                result.Data = await dao.GetAllRecyclersDt();
                result.Status = ResultEnum.Success;
            }
            catch (Exception)
            {

                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public async Task<Result<List<Recycler>>> GetAllRecyclersListASYNC()
        {
            Result<List<Recycler>> result = new Result<List<Recycler>>();
            result.Status = ResultEnum.Success;
            try
            {
                RecyclerDAO dao = new RecyclerDAO();
                result.Data = await dao.GetAllRecyclersListASYNC();

            }
            catch (Exception)
            {

                result.Status = ResultEnum.Fail;
            }
            return result;
        }
    }
}
