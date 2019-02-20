#JAG Method software developer assessment
## Answers

### 1. SEO (5min)

1) add here

2) add here

3) add here

4) add here

### 2. Responsive (15m)

1. Installed bootstrap for projects in the solution
2. Declared a header section of the asp.net index file with reference to bootstrap files listed below 

<head runat="server">

        <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
        <script src="~/Scripts/jquery-3.3.1.min.js"></script>
        <script src="~/Scripts/bootstrap.min.js"></script>
 </head>


### 3. Validation (15m)
Add any special implemetation instructions here.

My name is @Html.TextBoxFor(model => model.FirstName, new { @placeholder = Html.DisplayNameFor(model => model.FirstName), @required = "FirstName is required" }) @Html.TextBoxFor(model => model.Surname, new { @placeholder = Html.DisplayNameFor(model => model.Surname), @required = "LastName is required" })
You can contact me at @Html.TextBoxFor(model => model.EmailAddress, new { @placeholder = Html.DisplayNameFor(model => model.EmailAddress), @required = "Email address should be a value email address" }) or @Html.TextBoxFor(model => model.ContactNumber, new { @placeholder = Html.DisplayNameFor(model => model.ContactNumber), @required = "ContactNumber should be a valid telephone number" })
to help me save on insurance

### 4. JavaScript (20m)
Add any special implemetation instructions here.

### 5. Ajax calls (30m)
Add any special implemetation instructions here.

### 6. Call a REST webservice (25m)
Add any special implemetation instructions here.

Make sure that the WebHost calls the ServiceHost via REST.

### 7. ADO.Net (40m)
Add any SQL schema changes here

### 8. Poll DB (15m)
Add any SQL schema changes here

Make changes ServiceHost

### 9. SignalR (40m)
Add any SQL schema changes here

### 10. Data Analysis (30m)

1) Total Profit
**Answer**

**SQL**
`Select....`

2) Total Profit (Earnings less VAT)
**Answer**

**SQL**
`Select....`

3) Profitable campaigns
**Answer**

**SQL**
`Select....`

4) Average conversion rate
**Answer**

**SQL**
`Select....`

5) Pick 2 clients based on Profit & Conversion rate & Why?
**Answer**

**SQL**
`Select....`
