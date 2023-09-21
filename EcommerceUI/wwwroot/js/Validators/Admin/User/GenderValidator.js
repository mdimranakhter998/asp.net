$("document").ready(() => {

    $("#add-gender").validate({
        rules: {
            gender: {
                required: true,
                
            },
        },
        messages: {
            gender: {
                required: "please enter gender"
            },
        },

        submithandler: ((form,e) => {
            e.preventdefault()
            let value=$("#gender").val()
            //let data = new formdata()
            //data.append("gender", $("#gender").val())
            let data = {gender:value}
            $.ajax({
                url: "/add",
                type: "post",
              
              
                data:data,
                success: function (response) {
                    console.log(response)
                }
            })
        })



})
})