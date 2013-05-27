using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgenceVoyage
{
    public enum Profile { Admin, Agent }
    public enum CommErrors { Success, LoginFailed, ConnectionError }
    
    
    class ViewFactory
    {
        public static IView getViewInstance(Profile key){
        
            switch(key){
            
                case Profile.Admin: return new AdminView();
                case Profile.Agent: return new AgentView();
                default: return new AgentView();

            }
        
        
        }
    }

    interface IView {

         DialogResult Show(); 
    
    }


}
