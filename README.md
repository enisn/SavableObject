# SavableObject
Savable Objects in Xamarin Forms


## How To Use
>Create your object like below:


    
        public class AccountDetails : SavableObject
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public byte Age { get; set; }
        public bool IsNotificationEnabled { get; set; }
        
    }

 
    
 > Add your data to this object. And save it   
 
 
     AccountDetails aDetail = new AccountDetails();
            aDetail.Age = 15;
            aDetail.Email = "name@enisnecipoglu.com";
            aDetail.IsNotificationEnabled = true;
            aDetail.Username = "noname";
            
            
> You can load like below


            AccountDetails aDetail = new AccountDetails();
            aDetail.Load();
            DisplayAlert(aDetail.Email, aDetail.Username, "DONE");
            


> You can use easily to define a static property with editing your first class:

        public class AccountDetails : SavableObject
    {
        [IgnoreSave]
        public static AccountDetails Data { get; set; }

        static AccountDetails()
        {
            Data = new AccountDetails();
            Data.Load();
        }

        public string Email { get; set; }
        public string Username { get; set; }
        public byte Age { get; set; }
        public bool IsNotificationEnabled { get; set; }
        }

   



>[IgnoreSave] attribute allows not to save that property. And then you can use like that:

    void Display()
        {
            DisplayAlert(AccountDetails.Data.Email, AccountDetails.Data.Username, "DONE");
        }



   
