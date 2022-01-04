'use strict';

$(function () {
	
	//var UserCode = $("#username").val();
	//var Password = $("#password").val();
	//if ($("#error").val() == "Sucessful.") {
	//	var check = Validate();
	//	if (check==true) {
	//		setCookie('UserCode', UserCode, 7);
	//		setCookie('Password', Password, 7);
	//		location.href = 'https://bambooairways.com';
	//	}
	//	else {
	//		location.href = 'https://bambooairways.com';
 //       }

	//}
	//if ($("#error").val() == "Login fail.Please check your data input!") {
	//	alertify.alert($("#error").val());
	//}
	
	
	$("input[type='password'][data-eye]").each(function(i) {
		var $this = $(this),
			id = 'eye-password-' + i,
			el = $('#' + id);

		$this.wrap($("<div/>", {
			style: 'position:relative',
			id: id
		}));

		$this.css({
			paddingRight: 60
		});
		//$this.after($("<div/>", {
		//	html: 'Show',
		//	class: 'btn btn-primary btn-sm',
		//	id: 'passeye-toggle-'+i,
		//}).css({
		//		position: 'absolute',
		//		right: 10,
		//		top: ($this.outerHeight() / 2) - 12,
		//		padding: '2px 7px',
		//		fontSize: 12,
		//		cursor: 'pointer',
		//}));

		//$this.after($("<input/>", {
		//	type: 'hidden',
		//	id: 'passeye-' + i
		//}));

		var invalid_feedback = $this.parent().parent().find('.invalid-feedback');

		if(invalid_feedback.length) {
			$this.after(invalid_feedback.clone());
		}

		$this.on("keyup paste", function() {
			$("#passeye-"+i).val($(this).val());
		});

		$("#passeye-toggle-"+i).on("click", function() {
			if($this.hasClass("show")) {
				$this.attr('type', 'password');
				$this.removeClass("show");
				$(this).removeClass("btn-outline-primary");
			}else{
				$this.attr('type', 'text');
				$this.val($("#passeye-"+i).val());				
				$this.addClass("show");
				$(this).addClass("btn-outline-primary");
			}
		});
	});

	
       
 //   $("#login").submit(function () {
	////$("#login").click(function () {
 //       debugger
	//    // do something
	//	var UserCode = $("#email").val();
	//	var Password = $("#password").val();
	//	if(UserCode == "" || UserCode == undefined)
	//	{
	//		alertify.alert("Username not be blank!");
	//		return false;

	//	}
	//	if(Password == "" || Password == undefined)
	//	{
	//		alertify.alert("Password not be blank!");
	//		return false;
 //       }
	    
	//    var remember = myFunction();
	//    if (remember) {
	//        CallAjax();

	//    }
	//    else {
	//        CallAjax();
	//    }
	   
	   
	//	var form = $(this);
 //       if (form[0].checkValidity() === false) {
 //         event.preventDefault();
 //         event.stopPropagation();
 //       }
	//	form.addClass('was-validated');
	//});

	//function setCookie(name, value, days) {
	//    var expires = "";
	//    if (days) {
	//        var date = new Date();
	//        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
	//        expires = "; expires=" + date.toUTCString();
	//    }
	//    document.cookie = name + "=" + (value || "") + expires + "; path=/";
	//}
	//function getCookie(name) {
	//    var nameEQ = name + "=";
	//    var ca = document.cookie.split(';');
	//    for (var i = 0; i < ca.length; i++) {
	//        var c = ca[i];
	//        while (c.charAt(0) == ' ') c = c.substring(1, c.length);
	//        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
	//    }
	//    return null;
	//}

	//function eraseCookie(name) {
	//    setCookie(name, "", -1);
	//}
	//function Validate() {
	//    var check = false;
	//    if ($("#remember").is(":checked")) {
	//            check = true;
	//    }
	//    else {
	//        check = false;
	//    }

	    
	//    return check;

	//}
	
	//function CallAjax() {
	//	debugger	
	//	var UserCode = $("#email").val();
	//	var Password = $("#password").val();
	//    $.ajax({  
	//        url: '/Home/Index',  
	//        type: 'POST',  
 //           dataType: 'json',  
 //           contentType: "application/json; charset=utf-8",
 //           data: JSON.stringify(UserCode, Password),
 //       success: function(data, textStatus, xhr) {  
 //           var remember = myFunction();
 //           if (remember &&data.Message==='Sucessful.') {
 //                   //Must validate password or email is right
 //                   //setCookie('UserCode', UserCode, 7);
 //                   //setCookie('Password', Password, 7);
 //                   //setCookie('DeviceID', data.DeviceId, 7);
 //                   //window.location = "/Home/Index";
 //           }
 //           else {
 //               window.location = "/Home/Index";
 //           }
	//    },  
 //       error: function(xhr, textStatus, errorThrown) {  
	//        alertify.alert('Error in Database');  

	//    }  
 //   });
	 
	//}
});
