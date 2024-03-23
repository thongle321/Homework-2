exports.now = () => {
    return Date();
}
exports.today = () => {
    let d = new Date();
    return `${d.getDate()}/${d.getMonth() + 1}/${d.getFullYear()}`
}
exports.homNay = () => {
    let d = new Date();
    let months = ['tháng Một', 'tháng Hai', 'tháng Ba'];
    return `Ngày ${d.getDate()} ${months[d.getMonth()]} Năm ${d.getFullYear()}`
}
exports.getHours = () => {
    return (new Date().getHours())
}
exports.time = () => {
    let d = new Date()
    return `${d.getHours}:${d.getMinutes()}:${d.getSeconds}`
}