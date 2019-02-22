using System;

namespace MessagingExampleApp.Interfaces
{
    public interface ICommandService<T>
    {
        bool CreateItem(T item) 
        {
            
        }
    }
}
