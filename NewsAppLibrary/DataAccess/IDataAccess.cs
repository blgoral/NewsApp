namespace NewsAppLibrary.DataAccess;

public interface IDataAccess
{
    List<T> LoadData<T, U>(string sqlStatement, U parameters);
    void SaveData<T>(string sqlStatement, T parameters);
}