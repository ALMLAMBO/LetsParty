let isHomeHidden = false;
document.onkeypress = function(e) {
    if(e.key =="j")
    {
        let el = document.getElementsByClassName("content")[0];
        let el_2 = document.getElementsByClassName("create_party")[0];
        if(isHomeHidden){
            
            el.style.display = "flex";
            el_2.style.display = "none";

            console.log("show");
        }
        else {
            el.style.display = "none";
            el_2.style.display = "flex";
            console.log("none");
        }
        isHomeHidden = !isHomeHidden;
    }
}