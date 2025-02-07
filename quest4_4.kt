fun main(){
    println("введите X")
    var x = readLine()!!.toDouble()
    when{
        x<=7 -> println(-3*x+9)
        x>7 ->println(1/(x-7))
        else -> println("введено неверное значение")
    }

}