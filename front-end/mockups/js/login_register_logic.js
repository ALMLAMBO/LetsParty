        /* When the user clicks on the button, 
        toggle between hiding and showing the dropdown content */
        function myFunction() {
            document.getElementById("profileContentInfo").classList.toggle("show");
          }
          
          // Close the dropdown if the user clicks outside of it
          window.onclick = function(event) {
            if (!event.target.matches('.profile_button')) {
              var dropdowns = document.getElementsByClassName("content_content");
              var i;
              for (i = 0; i < dropdowns.length; i++) {
                  
              console.log(dropdowns.length);
                var openDropdown = dropdowns[i];
                if (openDropdown.classList.contains('show')) {
                  openDropdown.classList.remove('show');
                }
              }
            }
          }
  
          function openLoginForm() {
              document.getElementById("myForm").style.display = "flex";
              document.getElementById("myForm-register").style.display = "none";
          }
  
          function closeLoginForm() {
              document.getElementById("myForm").style.display = "none";
          }
  
  
          function openRegisterForm() {
              document.getElementById("myForm-register").style.display = "flex";
              document.getElementById("myForm").style.display = "none";
          }
  
          function closeRegisterForm() {
              document.getElementById("myForm-register").style.display = "none";
              console.log('ss');
          }