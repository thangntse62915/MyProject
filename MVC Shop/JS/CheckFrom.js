// JavaScript Document
function checkForm(){
		var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;

;		var s=document.register.email.value;
   		
		if(!s.match(mailformat))  
		{
			alert("You have entered an invalid email address!"); 
			return false;  
		}  
		var cs=document.register.cemail.value;
		if(s != cs)
		{alert(" Please input your mail in Confirm Email  ");
		return false;
		}
		var newPassword = document.register.password.value;
    	var regularExpression  =/^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9])(?!.*\s)/;
			
		
    	
		if(newPassword.length < 7 || newPassword.length > 12){
			alert("Password has length from 7 to 12 characters");
			return false;
		}
		
		if(!newPassword.match(regularExpression)) {
			alert("password contain at least one numeric digit, one uppercase, and one lowercase letter");
			return false;
		}
		var cnewPassword =document.register.cpassword.value;
		if(newPassword != cnewPassword)
		{
			alert(" Please input your password in Confirm password  ");
		return false;
		}
		var cnewPassword =document.register.cpassword.value;
		if(newPassword != cnewPassword)

		{alert(" Please input your password in Confirm password  ");
		return false;}
		if(document.register.agree.checked == false)
		{
			alert("Please check Agree before submit");
			return false;
		}





	return true;
}
function checkFormc(){
	var phoneformat =/(\d{3}-)*\d{7,10}/;
	var x=document.contact_form.phone.value;	
	if(!x.match(phoneformat))  
		{
			alert("You have entered an invalid phone"); 
			return false;  
		}  
	var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;

	var s=document.contact_form.email.value;
   		
		if(!s.match(mailformat))  
		{
			alert("You have entered an invalid email address!"); 
			return false;  
		}  
	
		return true;
}
	
