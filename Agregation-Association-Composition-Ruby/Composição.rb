class Car

  def initialize
    @price = 1.00
    @components = []
  end

  def add_component(component)
    @components << component
  end

  def price
    @components.map(&:price).inject(@price, :+)
  end
end

class Alarm

  def price
    0.20
  end
end

class AirConditioning

  def price
    0.30
  end
end

car = Car.new
car.add_component(Alarm.new)
car.add_component(AirConditioning.new)
puts car.price # => 1.5