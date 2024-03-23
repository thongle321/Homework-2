var datetime = require("./datetime")
exports.showHello = () => {
    let tb = ""
    if(datetime.getHours >= 4 && datetime.getHours <= 12)
    {
        tb += `chào buổi sáng ${datetime.time}`
        //return "Xin chào buổi sáng" + ` ${d.getHours()}:${d.getMinutes()}:${d.getSeconds()}`
    }
    else if (datetime.getHours >= 12 && datetime.getHours < 18)
    {
        tb += `chào buổi chiều ${datetime.time}`

        //return "Xin chào buổi trưa" + ` ${d.getHours()}:${d.getMinutes()}:${d.getSeconds()}`
    }
    else
    {
        tb += `chào buổi tối ${datetime.time}`
        //return "Xin chào buổi tối" + ` ${d.getHours()}:${d.getMinutes()}:${d.getSeconds()}`
    }
    return tb
}