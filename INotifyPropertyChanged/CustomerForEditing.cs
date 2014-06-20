using PostSharp.Patterns.Model;
namespace INotifyPropertyChanged
{
    /* Reason:
       Binding objects to the UI is a large and tedious task. 
     * You must implement INotifyPropertyChanged on every property that needs to be bound. 
     * You need to ensure that the underlying property getter correctly raises events 
     * so that the View knows that changes have occurred. 
     * The larger your codebase, the more work there is. 
    
       By using the Model Pattern Library to add INotifyPropertyChanged to your Model classes 
       you are able to eliminate all of the repetitive boilerplate coding tasks and code from the codebase.
     */
    [NotifyPropertyChanged]
    public class CustomerForEditing
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return string.Format("{0} {1}", this.FirstName, this.LastName); }
        }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    } 
}