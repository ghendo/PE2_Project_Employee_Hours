using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE2_Project_Employee_Hours.Data;
using PE2_Project_Employee_Hours.Domain;

namespace PE2_Project_Employee_Hours.Logic
{
    public class StateService
    {
        public ResultEnum InsertState(State state)
        {
            ResultEnum result = ResultEnum.Success;
            try
            {
                StateDAO dao = new StateDAO();
                dao.InsertState(state);
                result = ResultEnum.Fail;
            }
            catch
            {
                result = ResultEnum.Fail;
            }
            return result;
        }

        public Result<List<State>> getAllStates()
        {
            Result<List<State>> result = new Result<List<State>>();
            try
            {
                StateDAO dao = new StateDAO();
                result.Data = dao.GetAllStates();
                result.Status = ResultEnum.Success;
            }
            catch (Exception)
            {

                result.Status = ResultEnum.Fail;
            }
            return result;
        }

        public async Task<Result<List<State>>> getAllStatesListASYNC()
        {
            Result<List<State>> result = new Result<List<State>>();
            try
            {
                StateDAO dao = new StateDAO();
                result.Data = await dao.GetAllStatesListASYNC();
                result.Status = ResultEnum.Success;
            }
            catch (Exception)
            {

                result.Status = ResultEnum.Fail;
            }
            return result;
        }
    }
}
