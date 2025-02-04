fun main(){
    println("введите цифру от 0 до 9")
    var num1 = readLine()!!.toInt()
    when(num1){
        0 -> println("ноль")
        1 -> println("один")
        2 -> println("два")
        3 -> println("три")
        4 -> println("четыре")
        5 -> println("пять")
        6 -> println("шесть")
        7 -> println("семь")
        8 -> println("восемь")
        9 -> println("девять")
        else -> println("ввели не ту цифру");


    }
}