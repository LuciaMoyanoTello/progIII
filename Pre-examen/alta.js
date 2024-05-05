let nombre = $("#inputNombre");
let apellido = $("inputApellido");
let horas = $("inputHoras");

function Guardar(){
    let aux = 0;
    if(nombre.val() == ""){
        $("#errorNombre").show();
        aux++;
    }
    if(nombre.length > 30){
        $("#errorNombre").show();
        aux++;
    }
    if(apellido.val() == ""){
        $("#errorApellido").show();
        aux++;
    }
    if(apellido.length > 20){
        $("#errorApellido").show();
        aux++;
    }
    if(horas.val() == ""){
        $("#errorHoras").show();
        aux++;
    }
    if(isNaN(inputHoras.val())){
        $("#errorHoras").show();
        aux++;
    }
    if($("#inputNacionalidad option:selected").text()=="Seleccionar"){
        $("#errorNacionalidad").show();
        aux++;
    }
    console.log("Errores:"+aux);
    if(aux==0){
        apellido.val("");
        nombre.val("");
        horas.val("");
        Swal.fire({
            title: "Alta completada exitosamente!",
            icon: "success"
        });
    }
}
nombre.on("change",()=>{
    $("#errorNombre").hide();
});

apellido.on("change",()=>{
    $("#errorApellido").hide();
})

horas.on("change",()=>{
    $("#errorHoras").hide();
})

$("#inputNacionalidad").on("change",()=>{
    $("#errorNacionalidad").hide();
})