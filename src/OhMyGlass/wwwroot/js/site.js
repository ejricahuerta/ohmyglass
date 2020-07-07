
  $(document).ready(function() {
    $.fn.BeerSlider = function ( options ) {
      options = options || {};
      return this.each(function() {
        new BeerSlider(this, options);
      });
    };  
    $('.beer-slider').BeerSlider({start: 25});
  });
  
  $(window).on('load',function () {
    $('.loading').fadeOut('slow');
    $('.loading').remove();
  })