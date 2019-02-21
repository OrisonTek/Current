#JAG Method software developer assessment
## Answers

### 1. SEO (5min)

1) Properly define metakeywords properties

#MetaKeywords="JAGWEB LEADS WEBSITE "

2) Properly define metadescription properties

#MetaDescription="This page contains information about insurance covers and companies"

3)  URL Routing support for ASP.NET Web Forms 

4)  Response.RedirectPermanent() method 

### 2. Responsive (15m) 

# 2.1 Installed bootstrap for projects in the solution
# 2.2 Declared a header section of the asp.net index file with reference to bootstrap files listed below 

<head runat="server">

        <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
        <script src="~/Scripts/jquery-3.3.1.min.js"></script>
        <script src="~/Scripts/bootstrap.min.js"></script>
 </head>


### 3. Validation (15m)

My name is @Html.TextBoxFor(model => model.FirstName, new { @placeholder = Html.DisplayNameFor(model => model.FirstName), @required = "FirstName is required" }) @Html.TextBoxFor(model => model.Surname, new { @placeholder = Html.DisplayNameFor(model => model.Surname), @required = "LastName is required" })
You can contact me at @Html.TextBoxFor(model => model.EmailAddress, new { @placeholder = Html.DisplayNameFor(model => model.EmailAddress), @required = "Email address should be a value email address" }) or @Html.TextBoxFor(model => model.ContactNumber, new { @placeholder = Html.DisplayNameFor(model => model.ContactNumber), @required = "ContactNumber should be a valid telephone number" })
to help me save on insurance

### 4. JavaScript (20m)

<div id="counter"></div>

    <script>
	var n = localStorage.getItem('on_load_counter');
   
    if (n === null) {
        n = 0;
    }
    
	if ( n <6000000)
	{
	n = 6000000+n;
	}
    n++;

    localStorage.setItem("on_load_counter", n);

    document.getElementById('counter').innerHTML = n;
    </script>


### 5. Ajax calls (30m)
# Ajax call on submission
$("#theForm").ajaxForm({url: 'server.php', type: 'post'})

# Disable the button while processing the Ajax call
$("#ajaxStart").attr("disabled", true); 
                   
# Global start and stop to  display an Ajax loader while the call is running
$('#loading-image').bind('ajaxStart', function(){
    $(this).show();
}).bind('ajaxStop', function(){
    $(this).hide();
});


### 6. Call a REST webservice (25m)
Add any special implemetation instructions here.

Make sure that the WebHost calls the ServiceHost via REST.

### 7. ADO.Net (40m)
Add any SQL schema changes here

### 8. Poll DB (15m)

SELECT *
FROM leaddetail
WHERE datecolumn >= DATEADD(minutes,-1,GETDATE());

### 9. SignalR (40m)
	public  class  SampleHub : Hub
	{
	     // Use this variable to track user count
	     private  static  int _userCount = 0;
	
	     // Public hub methods  
	    :
	 
	     // Overridable hub methods  
	     public  override Task OnConnected()
	    {
	       _userCount ++;
	    }
	     public  override Task OnReconnected()
	    {
	        _userCount ++;
	    }
	     public  override Task OnDisconnected(bool stopCalled)
	    {
	       _userCount --;
	    }
	}

### 10. Data Analysis (30m)

1) Total Profit

select sum(earnings)earnings,
       sum(cost)cost 
	   into #profit
from leaddetail

select earnings , cost, (earnings - cost)profits
from #profit 

2) Total Profit (Earnings less VAT)
**Answer**

select ((earnings-(earnings*0.15))+cost)REprofit
from #profit

3) Profitable campaigns
**Answer**

	select distinct campaignid from 
	leaddetail where (earnings - cost) >0

4) Average conversion rate
**Answer**

**SQL**
	/*Number 4*/
	select sum(issold)/sum(isaccepted) from leaddetail


5) Pick 2 clients based on Profit & Conversion rate & Why?
**Answer**

**SQL**

	

	SELECT DISTINCT TOP (2) (earnings-cost)
                         FROM   leaddetail
