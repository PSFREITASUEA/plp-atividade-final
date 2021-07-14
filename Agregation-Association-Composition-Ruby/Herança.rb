class Veiculo
 attr_accessor :odometro
 attr_accessor :gasolina_usada

 def acelerar
   puts "Acelerar!"
 end

 def buzinar
  puts "Beep! Beep!"
 end

 def dirigir
   puts "Ligar 2 rodas dianteiras."
 end

 def media
  return @odometro / @gasolina_usada
 end
end

class Carro < Veiculo
end

carro = Carro.new
carro.odometer = 11432
carro.gasolina_usada = 366
puts "Média:"
puts carro.media