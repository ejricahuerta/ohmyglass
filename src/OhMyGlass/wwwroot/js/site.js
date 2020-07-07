
  $(document).ready(function() {
    $.fn.BeerSlider = function ( options ) {
      options = options || {};
      return this.each(function() {
        new BeerSlider(this, options);
      });
    };  
    $('.beer-slider').BeerSlider({start: 25});
    
    $("video").each(function(){ this.volume = 0.5; });

    $('#videModal').on('show.bs.modal', function (event) {
      var button = $(event.relatedTarget) 
      var src = button.data('src');
      var modal = $(this)
      var videosrc = modal.find('video source');
      var video = modal.find('video');
      $(videosrc).attr('src', src,);
      video.get(0).load();
      video.get(0).volume = .5;
      video.get(0).play();
    });

    $('#videModal').on('hidden.bs.modal', function (event) {
      var modal = $(this);
      var videosrc = modal.find('video source');
      var video = modal.find('video');
      $(videosrc).attr('src', '#',);

      video.get(0).pause();
    })
  });
  
  $(window).on('load',function () {
    var removeSelf = function () {
      $('.loading').remove();
    }
    $('.loading').fadeOut(1600,removeSelf);
  });